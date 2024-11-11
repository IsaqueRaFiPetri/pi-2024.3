using UnityEngine;

public class PuzzleWon : MonoBehaviour
{
    public BarController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller.EndPuzzle();
        }
    }
}
