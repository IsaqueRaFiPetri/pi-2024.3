using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Lever[] levers; // Array to store references to the levers
    public string secretCode = "1001"; // Example secret code (set to whatever you need)
    public GameObject door; // Reference to the door GameObject
    Animator doorAnim;
    bool isCodeCorrect;

    private void Start()
    {
        doorAnim = door.GetComponent<Animator>();
    }
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
            isCodeCorrect = true;
            OpenDoor();
        }
    }

    // Method to open the door
    private void OpenDoor()
    {
        // Example: move the door upward
        if(isCodeCorrect == true)
            doorAnim.SetBool("open", true);
       
        Debug.Log("Door opened!");
    }
}
