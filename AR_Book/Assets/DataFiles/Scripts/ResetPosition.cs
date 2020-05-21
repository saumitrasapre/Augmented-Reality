using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collide)
    {
        if(collide.gameObject.CompareTag("ShipWall"))
        {
            transform.localPosition = originalPos;
        }
        else if(collide.gameObject.CompareTag("AirplaneWall"))
        {
            transform.localPosition = originalPos;
        }
        else if(collide.gameObject.CompareTag("CloudWall"))
        {
            transform.localPosition = originalPos;
        }
    }
}
