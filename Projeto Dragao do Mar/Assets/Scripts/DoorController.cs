using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Lever[] levers; // Array to store references to the levers
    public string secretCode = "1001"; // Example secret code (set to whatever you need)
    public GameObject door; // Reference to the door GameObject

    // Method to check if the levers match the secret code
    public void CheckCode()
    {
        string currentCode = "";

        // Generate the current code based on the lever states
        foreach (Lever lever in levers)
        {
            currentCode += (int)lever.mode;
        }

        print(currentCode + "/" + secretCode);

        // If the code matches, open the door
        if (currentCode == secretCode)
        {
            OpenDoor();
        }
    }

    // Method to open the door
    private void OpenDoor()
    {
        // Example: move the door upward
        while (door.transform.position.y < 5) 
        {
            door.transform.position += new Vector3(0, 5, 0); // Adjust the movement as needed
        }
       
        Debug.Log("Door opened!");
    }
}
