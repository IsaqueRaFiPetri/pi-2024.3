using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; // Referência ao diálogo deste NPC
    public DialogueManager dialogueManager; // Referência ao DialogueManager
    
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