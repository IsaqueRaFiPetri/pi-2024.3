using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; // ReferÍncia ao diŠlogo deste NPC
    public DialogueManager dialogueManager; // ReferÍncia ao DialogueManager
    
    void Start()
    {
        TriggerDialogue();
    }
    public void TriggerDialogue()
    {
        dialogueManager.StartDialogue(dialogue);
    }
}
//ChatGPT