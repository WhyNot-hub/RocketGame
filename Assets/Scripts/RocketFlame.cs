using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFlame : MonoBehaviour
{
public bool isFlaming = false;
  
        void Update()
    {
        isFlaming = true;

        if (Input.GetKey(KeyCode.Space))
        {
            this.gameObject.GetComponent<ParticleSystem>();
        }
    }
}
