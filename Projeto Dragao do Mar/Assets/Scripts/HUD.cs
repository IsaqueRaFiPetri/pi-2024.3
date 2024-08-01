using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD instance;
    public Image ppBar;
    public GameObject conclusionPainel;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        SetPoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPoints()
    {
        ppBar.fillAmount = (float)PlayerStats.politicalPoints / (float)PlayerStats.politicsPointsToConclude;
    }
}
