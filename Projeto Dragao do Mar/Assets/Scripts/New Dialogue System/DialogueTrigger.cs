using UnityEngine;

public class DialogueTrigger : InteractableObject
{
    public Dialogue dialogue; // Refer�ncia ao di�logo deste NPC
    public DialogueManager dialogueManager; // Refer�ncia ao DialogueManager

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