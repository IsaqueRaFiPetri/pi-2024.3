using UnityEngine;

public class DialogueTrigger : InteractableObject
{
    public Dialogue dialogue; // ReferÍncia ao diŠlogo deste NPC
    public DialogueManager dialogueManager; // ReferÍncia ao DialogueManager
    public AudioSource audioSource;

    protected override void Interact()
    {
        PlayerInteraction.Instance.OnInteractionEffected.Invoke();
        PlayerStats.instance.SetUIingMode();
        TriggerDialogue();
        audioSource.Play();
    }
    public void TriggerDialogue()
    {
        dialogueManager.StartDialogue(dialogue);
    }

    
}