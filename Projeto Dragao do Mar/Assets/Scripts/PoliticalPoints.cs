using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoliticalPoints : MonoBehaviour //Este vai num vazio
{  
    // Exemplo de método para quando o jogador interagir com um NPC
    public static void OnNPCInteraction(int points)
    {
        PlayerStats.GainPoints(points);  // Por exemplo, o jogador ganha 10 pontos ao falar com um NPC
    }

    // Exemplo de método para quando o jogador completar uma quest
    public void OnQuestCompleted(int points)
    {
        PlayerStats.GainPoints(points);  // Por exemplo, o jogador ganha 20 pontos ao completar uma quest
    }
    
    // Exemplo de método para quando o jogador completar um puzzle
    public void OnPuzzlerCompleted(int points)
    {
        PlayerStats.GainPoints(points);  // Por exemplo, o jogador ganha 20 pontos ao completar uma quest
    }
}
