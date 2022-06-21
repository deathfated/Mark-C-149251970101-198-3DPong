using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddyController : MonoBehaviour
{
    public float speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<RigidBody>();
    }

    private void Update()
    {
        //move object & //get input
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
