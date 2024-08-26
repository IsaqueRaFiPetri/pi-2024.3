using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; // Refer�ncia ao di�logo deste NPC
    public DialogueManager dialogueManager; // Refer�ncia ao DialogueManager
    
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