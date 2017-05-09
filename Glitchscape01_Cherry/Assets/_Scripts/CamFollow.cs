using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour 
{
    public GameObject plaerShip;

    public float speed = 2.0f;

    void Update()
    {
        Vector3 velocity = Vector3.zero;
        Vector3 forward = plaerShip.transform.forward * 10.0f;
        Vector3 needPos = plaerShip.transform.position - forward;
        transform.position = Vector3.SmoothDamp(transform.position, needPos,
                                                ref velocity, 0.05f);
        transform.LookAt(plaerShip.transform);
        transform.rotation = plaerShip.transform.rotation;
    }
}


