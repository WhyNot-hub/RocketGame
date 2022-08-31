using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    public bool isThrusting = false;
    void Update()
    {
        isThrusting = true;
        if (Input.GetKey(KeyCode.Space))
        {
            this.gameObject.GetComponent<Light>().enabled = true;
        }
        else this.gameObject.GetComponent<Light>().enabled = false;
    }
}
