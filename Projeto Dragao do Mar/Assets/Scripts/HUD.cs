using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour //Esse vai aonde está a barra
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

    public void SetPoints()
    {
        ppBar.fillAmount = (float)PlayerStats.politicalPoints / (float)PlayerStats.politicsPointsToConclude;
    }
}
