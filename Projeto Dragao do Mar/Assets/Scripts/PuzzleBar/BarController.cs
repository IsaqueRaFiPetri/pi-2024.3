using System;
using UnityEngine;
using UnityEngine.UI;

public class BarController : InteractableObject
{
    public bool isPuzzleActive = false;
    //public Transform playerJoint;   //somente a Joint

    public Transform player;        //player Todo
    public Transform startPoint;    //Ponto de início do puzzle

    public GameObject line;
    public BoxCollider lineCol;

    protected override void Interact()
    {
        StartPuzzle();
    }
    
    void Update()
    {
        // Código para interromper o puzzle com a tecla Escape
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
        // Aqui você ativa as funções específicas do puzzle
    }
    void StopPuzzle()
    {
        isPuzzleActive = false;
        // Desativa componentes e configurações para parar o puzzle
        Debug.Log("Puzzle Parado");
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
