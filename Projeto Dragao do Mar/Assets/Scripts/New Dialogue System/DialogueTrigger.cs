using UnityEngine;

public class DialogueTrigger : InteractableObject
{
    public Dialogue dialogue; // Refer�ncia ao di�logo deste NPC
    public DialogueManager dialogueManager; // Refer�ncia ao DialogueManager
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