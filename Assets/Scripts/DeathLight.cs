using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLight : MonoBehaviour
{
    public bool deathLightOn = false;

    void Start()
    {
        deathLightOn = true;
        {
            if (GetComponent<RocketMovement>().enabled == false)
            {
                this.gameObject.GetComponent<Light>().enabled = true;
            }

            else this.gameObject.GetComponent<Light>().enabled = false;

        }
    }
}
    


