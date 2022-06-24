using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public bool isBlack;
    public bool isCyan;
    public bool isMagenta;
    public ScoreManager manager;

    public GameObject balz;
    public GameObject balz2;
    public GameObject balz3;
    public GameObject balz4;
    public GameObject balz5;

    private void OnTriggerEnter(Collider collision)
    {
        BolController bola = collision.GetComponent<BolController>();
        if (bola != null)
        {
            if (isBlack)
            {
                manager.AddBlackScore(1);
            }
            else if (isCyan)
            {
                manager.AddCyanScore(1);
            }
            else if (isMagenta)
            {
                manager.AddMagentaScore(1);
            }
            else
            {
                manager.AddYellowScore(1);
            }

            bola.ResetBall();


            if (collision.gameObject.name == "Ball")
            {
                balz.SetActive(false);
                Invoke("ActivateBalz1", 5.0f);
            }
            if (collision.gameObject.name == "Ball2")
            {
                balz2.SetActive(false);
                Invoke("ActivateBalz2", 5.0f);
            }
            if (collision.gameObject.name == "Ball3")
            {
                balz3.SetActive(false);
                Invoke("ActivateBalz3", 5.0f);
            }
            if (collision.gameObject.name == "Ball4")
            {
                balz4.SetActive(false);
                Invoke("ActivateBalz4", 5.0f);
            }
            if (collision.gameObject.name == "Ball5")
            {
                balz5.SetActive(false);
                Invoke("ActivateBalz5", 5.0f);
            }
        }
    }

    public void ActivateBalz1()
    {
        balz.SetActive(true);
    }
    public void ActivateBalz2()
    {
        balz2.SetActive(true);
    }
    public void ActivateBalz3()
    {
        balz3.SetActive(true);
    }
    public void ActivateBalz4()
    {
        balz4.SetActive(true);
    }
    public void ActivateBalz5()
    {
        balz5.SetActive(true);
    }
}
