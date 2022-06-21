using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddyController : MonoBehaviour
{
    public float speed;

    public KeyCode leftKey;
    public KeyCode rightKey;

    private Rigidbody rig;

    public string PaddleName;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //move object & //get input
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (PaddleName == "North")
        {
            if (Input.GetKey(leftKey))
            {
                return Vector3.left * speed;
            }
            if (Input.GetKey(rightKey))
            {
                return Vector3.right * speed;
            }
        }

        if (PaddleName == "East")
        {
            if (Input.GetKey(leftKey))
            {
                return Vector3.forward * speed;
            }
            if (Input.GetKey(rightKey))
            {
                return Vector3.back * speed;
            }
        }

        if (PaddleName == "South")
        {
            if (Input.GetKey(leftKey))
            {
                return Vector3.left * speed;
            }
            if (Input.GetKey(rightKey))
            {
                return Vector3.right * speed;
            }
        }

        if (PaddleName == "West")
        {
            if (Input.GetKey(leftKey))
            {
                return Vector3.forward * speed;
            }
            if (Input.GetKey(rightKey))
            {
                return Vector3.back * speed;
            }
        }
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
