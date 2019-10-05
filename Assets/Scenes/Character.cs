using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Vector3 vec;
    Transform body;
    Vector3 moveDir = Vector3.zero;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        body = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        Staring();
        Movement();
    }

    void Movement()//Moves the character in the direction of where you press
    {
        moveDir = Vector3.zero;
        if(Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.S))
        {
            moveDir.z = 0;
            Debug.Log("Pressing W and S");
        }
        else if(Input.GetKey(KeyCode.W))
        {
            moveDir.z = 1;
            Debug.Log("Pressing W");
        }
        else if(Input.GetKey(KeyCode.S))
        {
            moveDir.z = -1;
            Debug.Log("Pressing S");
        }
        //else
        //{
        //    moveDir.x = 0;
        //}

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            moveDir.x = 0;
            Debug.Log("Pressing A and D");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDir.x = 1;
            Debug.Log("Pressing D");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDir.x = -1;
            Debug.Log("Pressing A");
        }
        //else
        //{
        //    moveDir.z = 0;
        //}

        Vector3 tmp = transform.position;
        tmp += moveDir;
        transform.position = Vector3.MoveTowards(transform.position, tmp, speed*Time.deltaTime);
    }

    void Staring()//Makes the character look at where the mouse points
    {
        if (Utility.MousePoint(ref vec))
        {
            //Debug.Log("Raycasting : "+vec);
        }

        //transform.LookAt(vec);
        body.LookAt(vec);
    }
}
