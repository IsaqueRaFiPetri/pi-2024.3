using UnityEngine;

public abstract class DialogueNode : ScriptableObject //24
{
    [SerializeField] private NarrationLine m_DialogueLine;
    public NarrationLine DialogueLine => m_DialogueLine; //2
    public abstract bool CanBeFollowedByNode(DialogueNode node); //3
    public abstract void Accept(DialogueNodeVisitor visitor); //3 
}
