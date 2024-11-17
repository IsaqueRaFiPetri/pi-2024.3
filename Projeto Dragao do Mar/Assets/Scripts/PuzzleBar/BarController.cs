using System;
using UnityEngine;

public class BarController : InteractableObject
{
    public bool isPuzzleActive = false;
    public GameObject puzzlePainel;

    public Transform player;        //player Todo
    public Transform startPoint;    //Ponto de in�cio do puzzle

    public GameObject line;
    public BoxCollider[] lineCol;

    protected override void Interact()
    {
        puzzlePainel.SetActive(true);
        PlayerStats.instance.SetUIingMode();
    }
    
    void Update()
    {
        // C�digo para interromper o puzzle com a tecla Escape
        if (isPuzzleActive && Input.GetKeyDown(KeyCode.P))
        {
            EndPuzzle();
        }
    }
    public void StartPuzzle()
    {
        PlayerStats.instance.SetWalkingMode();
        puzzlePainel.SetActive(false);

        isPuzzleActive = true;
        line.SetActive(true);
        Debug.Log("Puzzle Iniciado");
        // Aqui voc� ativa as fun��es espec�ficas do puzzle
    }
    public void RestartPuzzle()
    {
        player.position = startPoint.position; // Reseta o jogador para o in�cio
        // Opcional: Reinicia a c�mera ou outros par�metros do puzzle
    }

    internal void EndPuzzle()
    {
        isPuzzleActive = false;
        line.SetActive(false);
        Debug.Log("Puzzle Completado!!! :-)");
    }
}
