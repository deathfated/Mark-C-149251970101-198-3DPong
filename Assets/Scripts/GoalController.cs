using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public Collider ball2;
    public bool isBlack;
    public bool isCyan;
    public bool isMagenta;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball || collision == ball2)
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
        }
    }
}
