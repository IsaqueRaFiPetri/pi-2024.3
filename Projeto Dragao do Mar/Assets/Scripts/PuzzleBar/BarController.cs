using System;
using UnityEngine;
using UnityEngine.UI;

public class BarController : InteractableObject
{
    public bool isPuzzleActive = false;
    //public Transform playerJoint;   //somente a Joint

    public Transform player;        //player Todo
    public Transform startPoint;    //Ponto de in�cio do puzzle

    public GameObject line;
    public BoxCollider lineCol;

    protected override void Interact()
    {
        StartPuzzle();
    }
    
    void Update()
    {
        // C�digo para interromper o puzzle com a tecla Escape
        if (isPuzzleActive && Input.GetKeyDown(KeyCode.P))
        {
            StopPuzzle();
        }
    }
    void StartPuzzle()
    {
        isPuzzleActive = true;
        line.SetActive(true);
        Debug.Log("Puzzle Iniciado");
        // Aqui voc� ativa as fun��es espec�ficas do puzzle
    }
    void StopPuzzle()
    {
        isPuzzleActive = false;
        // Desativa componentes e configura��es para parar o puzzle
        Debug.Log("Puzzle Parado");
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
