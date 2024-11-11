using UnityEngine;

public class LinePuzzle : MonoBehaviour
{
    public Transform player;
    public Transform startPoint;
    public float allowedDistance = 1.0f; // tolerância para erro
    public BarController controller;

    void Start()
    {
        float distance = Vector3.Distance(player.position, startPoint.position);
        if (distance > allowedDistance)
        {
            controller.RestartPuzzle();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller.RestartPuzzle();
        }
    }
}

