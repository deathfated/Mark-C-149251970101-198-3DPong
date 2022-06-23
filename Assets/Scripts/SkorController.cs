using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorController : MonoBehaviour
{
    public Text skorbla;
    public Text skorcya;
    public Text skormag;
    public Text skoryel;

    public ScoreManager manager;

    private void Update()
    {
        skorbla.text = manager.BlackScore.ToString();
        skorcya.text = manager.CyanScore.ToString();
        skormag.text = manager.MagentaScore.ToString();
        skoryel.text = manager.YellowScore.ToString();
    }
}
