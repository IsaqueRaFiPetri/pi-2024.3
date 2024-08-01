using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteraction : InteractableObject
{
    public Character charac1;
    protected override void Interact()
    {
        DialogueSystem.instance.StartDialogue(charac1);
        PlayerStats.instance.SetUIingMode();
    }
}
