using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool isActivated = false; // Track if the lever is activated
    public string leverID; // Unique ID for each lever to identify them
    public bool isDown;

    // Reference to the door controller script
    private DoorController doorController;

    private void Start()
    {
        // Find the DoorController in the scene
        doorController = FindObjectOfType<DoorController>();
    }

    public void FixedUpdate()
    {
        /*if(isDown)
        {
            
        }
        else
        {

        }*/
    }

    // Method to toggle the lever
    public void ToggleLever()
    {
        isActivated = !isActivated;
        // Call the method in DoorController to check if the puzzle is solved
        doorController.CheckCode();
    }

    // Example of interacting with the lever (this can be tied to a key press or other input)
    private void OnMouseDown()
    {
        ToggleLever();
    }
}
