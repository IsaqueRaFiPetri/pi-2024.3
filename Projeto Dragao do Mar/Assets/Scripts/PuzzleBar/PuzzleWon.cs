using UnityEngine;

public class PuzzleWon : MonoBehaviour
{
    public BarController controller;
    public QuestsSystem questSys;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            questSys.isQuestComplete = true;
            questSys.CompleteQuest();
            controller.EndPuzzle();
        }
    }
}
