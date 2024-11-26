using UnityEngine;

public class ColliderRespawn : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;
        }
    }
}
