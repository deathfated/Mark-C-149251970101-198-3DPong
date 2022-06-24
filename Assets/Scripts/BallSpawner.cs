using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public int balz1spawn;
    public int balz2spawn;
    public int balz3spawn;
    public int balz4spawn;
    public int balz5spawn;

    private float timer;

    public GameObject balz;
    public GameObject balz2;
    public GameObject balz3;
    public GameObject balz4;
    public GameObject balz5;

    public bool Spawn1Complete;
    public bool Spawn2Complete;
    public bool Spawn3Complete;
    public bool Spawn4Complete;
    public bool Spawn5Complete;

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);

        if (timer >= balz1spawn && Spawn1Complete == false)
        {
            if (balz.activeSelf == true)
            {
                return;
            }
            balz.SetActive(!balz.activeInHierarchy);
            Spawn1Complete = true;
        }
        if (timer >= balz2spawn && Spawn2Complete == false)
        {
            if (balz2.activeSelf == true)
            {
                return;
            }
            balz2.SetActive(!balz2.activeInHierarchy);
            Spawn2Complete = true;
        }
        if (timer >= balz3spawn && Spawn3Complete == false)
        {
            if (balz3.activeSelf == true)
            {
                return;
            }
            balz3.SetActive(!balz3.activeInHierarchy);
            Spawn3Complete = true;
        }
        if (timer >= balz4spawn && Spawn4Complete == false)
        {
            if (balz4.activeSelf == true)
            {
                return;
            }
            balz4.SetActive(!balz4.activeInHierarchy);
            Spawn4Complete = true;
        }
        if (timer >= balz5spawn && Spawn5Complete == false)
        {
            if (balz5.activeSelf == true)
            {
                return;
            }
            balz5.SetActive(!balz5.activeInHierarchy);
            Spawn5Complete = true;
        }
    }
}
