using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolController : MonoBehaviour
{ 

    public Vector3 speed;
    public Vector3 resetPosition;

    private Rigidbody rig;

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }
}