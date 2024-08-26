using UnityEngine;

public class DialogueTrigger : InteractableObject
{
    public Dialogue dialogue; // ReferÍncia ao diŠlogo deste NPC
    public DialogueManager dialogueManager; // ReferÍncia ao DialogueManager

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