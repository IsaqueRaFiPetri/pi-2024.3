using UnityEngine;

public class DialogueTrigger : InteractableObject
{
    public Dialogue dialogue; // Referência ao diálogo deste NPC
    public DialogueManager dialogueManager; // Referência ao DialogueManager
    public AudioSource audioSource;
    public bool hasGivedPoints;
    
    PoliticalPoints ppPoints;
    public int pointsTeRecieve;

    private void Start()
    {
        print(hasGivedPoints);
        ppPoints = FindObjectOfType<PoliticalPoints>();
    }
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
    public void DialogueGivePoints()
    {
        if(hasGivedPoints == false) 
        {
            PoliticalPoints.OnNPCInteraction(1);
        }
        else
        {
            return;
        }
    }
    
}