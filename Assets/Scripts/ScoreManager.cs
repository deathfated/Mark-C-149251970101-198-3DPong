using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int BlackScore;
    public int CyanScore;
    public int MagentaScore;
    public int YellowScore;
    public int maxScore;
    public BolController bol;
    public BolController bol2;

    public int PlayerLost;
    public bool BlackLost;
    public bool CyanLost;
    public bool MagentaLost;
    public bool YellowLost;

    public Collider BlackPadle;
    public Collider CyanPadle;
    public Collider MagentaPadle;
    public Collider YellowPadle;

    public GameObject GOCanva;
    public GameObject BlackText;
    public GameObject CyanText;
    public GameObject MagText;
    public GameObject YellowText;

    private Vector3 scaleChangeH;
    private Vector3 scaleChangeV;

    public void Start()
    {
        scaleChangeH = new Vector3(16, 1, 1);
        scaleChangeV = new Vector3(1, 1, 16);
        PlayerLost = 0;
    }

    public void AddBlackScore(int decrement)
    {
        BlackScore += decrement;
        bol.ResetBall();
        bol2.ResetBall();
        if (BlackScore >= maxScore)
        {
            BlackLose();
        }
    }
    public void AddCyanScore(int decrement)
    {
        CyanScore += decrement;
        bol.ResetBall();
        bol2.ResetBall();
        if (CyanScore >= maxScore)
        {
           CyanLose();
        }
    }
    public void AddMagentaScore(int decrement)
    {
        MagentaScore += decrement;
        bol.ResetBall();
        bol2.ResetBall();
        if (MagentaScore >= maxScore)
        {
            MagentaLose();
        }
    }
    public void AddYellowScore(int decrement)
    {
        YellowScore += decrement;
        bol.ResetBall();
        bol2.ResetBall();
        if (YellowScore >= maxScore)
        {
            YellowLose();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void BlackLose()
    {
        BlackLost = true;
        PlayerLost++;
        BlackPadle.transform.localPosition = new Vector3(0, 1, -10);
        BlackPadle.transform.localScale = scaleChangeH;
    }
    public void CyanLose()
    {
        CyanLost = true;
        PlayerLost++;
        CyanPadle.transform.localPosition = new Vector3(-10, 1, 0);
        CyanPadle.transform.localScale = scaleChangeV;
    }
    public void MagentaLose()
    {
        MagentaLost = true;
        PlayerLost++;
        MagentaPadle.transform.localPosition = new Vector3(0, 1, 10);
        MagentaPadle.transform.localScale = scaleChangeH;
    }
    public void YellowLose()
    {
        YellowLost = true;
        PlayerLost++;
        YellowPadle.transform.localPosition = new Vector3(10, 1, 0);
        YellowPadle.transform.localScale = scaleChangeV;
    }

    public void Update()
    {
        if (PlayerLost == 3)
        {
            GOCanva.SetActive(!GOCanva.activeInHierarchy);
            if (BlackLost && CyanLost && MagentaLost)
            {
                YellowText.SetActive(!YellowText.activeInHierarchy);
            }
            if (BlackLost && CyanLost && YellowLost)
            {
                MagText.SetActive(!MagText.activeInHierarchy);
            }
            if (BlackLost && YellowLost && MagentaLost)
            {
                CyanText.SetActive(!CyanText.activeInHierarchy);
            }
            if (YellowLost && CyanLost && MagentaLost)
            {
                BlackText.SetActive(!BlackText.activeInHierarchy);
            }
            PlayerLost = 5;
        }
    }
}
