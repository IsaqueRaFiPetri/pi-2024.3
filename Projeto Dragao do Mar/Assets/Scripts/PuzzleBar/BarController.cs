using System;
using UnityEngine;

public class BarController : InteractableObject
{
    public bool isPuzzleActive = false;
    public GameObject puzzlePainel;

    public Transform player;        //player Todo
    public Transform startPoint;    //Ponto de início do puzzle

    public GameObject line;
    public BoxCollider[] lineCol;

    protected override void Interact()
    {
        puzzlePainel.SetActive(true);
        PlayerStats.instance.SetUIingMode();
    }
    
    void Update()
    {
        // Código para interromper o puzzle com a tecla Escape
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
        // Aqui você ativa as funções específicas do puzzle
    }
    public void RestartPuzzle()
    {
        player.position = startPoint.position; // Reseta o jogador para o início
        // Opcional: Reinicia a câmera ou outros parâmetros do puzzle
    }

    internal void EndPuzzle()
    {
        isPuzzleActive = false;
        line.SetActive(false);
        Debug.Log("Puzzle Completado!!! :-)");
    }
}
