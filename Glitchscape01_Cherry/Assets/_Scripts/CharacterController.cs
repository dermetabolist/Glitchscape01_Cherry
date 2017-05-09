using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    float speed = 1f;
    float rotSpeed = .5f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.forward * speed);

        if(Input.GetKey("left"))
        {
            transform.Rotate(Vector3.forward * rotSpeed);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(Vector3.forward * -rotSpeed);
        }

        if(Input.GetKey("up"))
        {
            transform.Rotate(Vector3.left * -rotSpeed);
        }

        if (Input.GetKey("down"))
        {
            transform.Rotate(Vector3.left * rotSpeed);
        }
    }
}
