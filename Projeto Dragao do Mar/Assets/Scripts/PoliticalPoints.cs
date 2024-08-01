using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoliticalPoints : MonoBehaviour
{

    public static int ppMax;
    int ppAmount;
    public Image ppBar;
    public GameObject uWinPainel;

    void Update()
    {
        if(ppAmount >= ppMax)
        {
            uWinPainel.SetActive(true);
        }
    }
    public void SetPP()
    {
        ppBar.fillAmount = (float)ppAmount / (float)ppMax;
    }

}
