using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Character character;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueSystem>().StartDialogue(character);
    }
}
