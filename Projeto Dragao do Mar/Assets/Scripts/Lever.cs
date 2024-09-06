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

    private void Start()
    {
        doorController = FindObjectOfType<DoorController>();
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        switch (mode)
        {
            case LeverMode.Down:
                isDown = true;
                anim.SetBool("isDown", isDown);
                break;

            case LeverMode.Up:
                isDown = false;
                anim.SetBool("isDown", isDown);
                break;
        }
    }

    void SetleverMode()
    {
        if (isDown)
        {
            mode = LeverMode.Down;
        }
        else
        {
            mode = LeverMode.Up;
        }
    }
    protected override void Interact()
    {
        isDown = !isDown;
        isActivated = !isActivated;
        SetleverMode();
        // Call the method in DoorController to check if the puzzle is solved
        doorController.CheckCode();
    }
}
//https://www.youtube.com/watch?v=UEP6DdCbaK8