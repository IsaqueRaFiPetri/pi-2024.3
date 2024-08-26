using UnityEngine;

public class DialogueTrigger : InteractableObject
{
    public Dialogue dialogue; // Referência ao diálogo deste NPC
    public DialogueManager dialogueManager; // Referência ao DialogueManager

    protected override void Interact()
    {
        PlayerInteraction.Instance.OnInteractionEffected.Invoke();
        PlayerStats.instance.SetUIingMode();
        TriggerDialogue();
    }
    public void TriggerDialogue()
    {
        dialogueManager.StartDialogue(dialogue);
    }

    
}
//ChatGPT