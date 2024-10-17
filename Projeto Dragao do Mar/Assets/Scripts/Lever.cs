using UnityEngine;

public enum LeverMode
{
    Down, Up 
}
public class Lever : InteractableObject
{
    public bool isActivated = false; // Track if the lever is activated
    public string leverID; // Unique ID for each lever to identify them
    public bool isDown;
    Animator anim;

    public LeverMode mode;
    // Reference to the door controller script
    private DoorController doorController;

    public AudioSource leverSound;
    public AudioClip leverClip;

    private void Start()
    {
        doorController = FindObjectOfType<DoorController>();
        anim = GetComponent<Animator>();

        // Randomize the initial state of the lever
        RandomizeLeverState();
    }

    private void RandomizeLeverState()
    {
        // Randomly set the lever to either Down or Up
        if (Random.Range(0, 2) == 0) // Generates either 0 or 1
        {
            mode = LeverMode.Down;
            isDown = true;
        }
        else
        {
            mode = LeverMode.Up;
            isDown = false;
        }
        // Update the animation and state accordingly
        UpdateLeverState();
    }

    // Update the animation and state based on the mode
    private void UpdateLeverState()
    {
        // Sync the animator and the lever state
        anim.SetBool("isDown", isDown);

    }

    void SetLeverMode()
    {
        if (isDown)
        {
            mode = LeverMode.Down;
            isDown = true;
        }
        else
        {
            mode = LeverMode.Up;
            isDown = false;
        }
    }
    protected override void Interact()
    {
        isDown = !isDown;
        isActivated = !isActivated;
        SetLeverMode();
        UpdateLeverState();
        // Call the method in DoorController to check if the puzzle is solved
        doorController.CheckCode();
        leverSound.PlayOneShot(leverClip);

    }
}
//https://www.youtube.com/watch?v=UEP6DdCbaK8