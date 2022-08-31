using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Horizontal Movement")]
    [SerializeField] float moveSpeed = 1f;
    public Vector2 direction;
    [SerializeField] float jumpForce = 10f;
    [SerializeField] LayerMask groundLayers;
    [SerializeField] SphereCollider col;
    [SerializeField] AudioClip jump;
    private bool facingRight = true;

    [Header("Components")]
    public Animator animator;
    AudioSource audioSource;
    Rigidbody rb;

    [Header("Physics")]
    public float maxSpeed = 7f;
    public float linearDrug = 4;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));




        //add JumpForce
        if (IsGrouded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(jump);
            }
            else
            {
                audioSource.Stop();
            }
        }
    }

    void moveCharacter (float horizontal)
    {
        rb.AddForce(Vector2.right * horizontal * moveSpeed);

        animator.SetFloat("horizontal", Mathf.Abs(rb.velocity.x));

        if((horizontal> 0 && !facingRight) || (horizontal < 0 && facingRight))
        {
            Flip();
        }
        if (Mathf.Abs(rb.velocity.x) > maxSpeed)
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        }
    }
    private void FixedUpdate()
    {
        moveCharacter(direction.x);
    }
    void Flip ()
    {
        facingRight = !facingRight;
        transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
    }

    private bool IsGrouded()
    {
       return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, 
            col.bounds.min.y,col.bounds.center.z), col.radius * .9f, groundLayers);
    }
}

