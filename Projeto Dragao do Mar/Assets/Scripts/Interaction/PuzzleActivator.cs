using UnityEngine;

public class PuzzleActivator : InteractableObject
{
    public GameObject player;
    public Transform targetPosition;
    public FirstPersonController controller;


    // Array or list to hold the objects that will shoot
    public GameObject[] objectsToShoot;
    public GameObject weaponObj;
    public GameObject puzzleUI;
    public GameObject timer;

    // Method that gets called when the player interacts with the activator
    protected override void Interact()
    {
        // Teleport the player to the target position
        TeleportPlayer();

        // Summon the objects to start shooting
        SummonObjects();
    }

    void TeleportPlayer()
    {
        // Move the player to the target position
        player.transform.position = targetPosition.position;
        controller.playerCanMove = false;
    }

    public void SummonObjects()
    {
        weaponObj.SetActive(true);
        puzzleUI.SetActive(true);
        // Loop through the array and activate or enable the shooting behavior
        foreach (GameObject obj in objectsToShoot)
        {
            // You can enable a shooting script, start an animation, etc.
            obj.SetActive(true); // Simple example of activating objects
        }
    }
}
