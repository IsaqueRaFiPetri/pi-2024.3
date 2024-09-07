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
        if (ppAmount >= ppMax)
        {
            uWinPainel.SetActive(true);
        }
    }
    public void AddPoliticalPoints(int points)
    {
        ppAmount += points;
        //ppAmount = Mathf.Clamp(currentPoliticalPoints, 0, maxPoliticalPoints);
        //UpdatePoliticalPointsBar();
    }

    // Exemplo de método para quando o jogador interagir com um NPC
    public void OnNPCInteraction()
    {
        AddPoliticalPoints(10);  // Por exemplo, o jogador ganha 10 pontos ao falar com um NPC
    }

    // Exemplo de método para quando o jogador completar uma quest
    public void OnQuestCompleted()
    {
        AddPoliticalPoints(20);  // Por exemplo, o jogador ganha 20 pontos ao completar uma quest

    }
}
