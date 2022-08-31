using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindScript : MonoBehaviour
{
    public GameObject player;
    public GameObject rocket;
    public GameObject PlayerCamera;
    public GameObject RocketCamera;

    AudioListener PlayerCameraAudioLis;
    AudioListener RocketCameraAudioLis;

    [SerializeField] float timeToWait = 1f;
    MeshRenderer renderer;
    BoxCollider collision;
    SphereCollider sphereCollision;


    private void Start()
    {
     renderer = GetComponent<MeshRenderer>();
     renderer.enabled = true;
     collision = GetComponent<BoxCollider>();
     collision.enabled = true;
     sphereCollision = GetComponent<SphereCollider>();
     sphereCollision.enabled = true;

        //Get Camera Listener
        PlayerCameraAudioLis = PlayerCamera.GetComponent<AudioListener>();
        RocketCameraAudioLis = RocketCamera.GetComponent<AudioListener>();

        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    private void Update()
    {
        cameraSwitch();
    }
    void OnCollisionEnter(Collision other)
    {
        ColissionLogic(other);
    }

    private void ColissionLogic(Collision other)

    {
        switch (other.gameObject.tag)
        {

        case "Rocket":
        playerSwitch();
        transperent();
        cameraSwitch();
        break;

        }
    }

    void playerSwitch()
    {
        if (Time.time > timeToWait)
        {
        player.GetComponent<PlayerMovement>().enabled = false;
        rocket.GetComponent<RocketMovement>().enabled = true;
        }
    }
    void transperent()
    {
        collision.enabled = false;
        renderer.enabled = false;
        sphereCollision.enabled = false;
    }
    void cameraSwitch()
    {
        cameraChangeCouter();
    }

    void cameraChangeCouter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionChange(cameraPositionCounter);
    }

    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if (camPosition ==0)
        {
            PlayerCamera.SetActive(true);
            PlayerCameraAudioLis.enabled = true;

            RocketCamera.SetActive(true);
            RocketCameraAudioLis.enabled = true;
        }
        if (camPosition ==1)
        {
            RocketCamera.SetActive(true);
            RocketCameraAudioLis.enabled = true;

            PlayerCamera.SetActive(true);
            PlayerCameraAudioLis.enabled = true;
        }
    }
}