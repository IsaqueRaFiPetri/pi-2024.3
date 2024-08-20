using UnityEngine;

[CreateAssetMenu (menuName = "Scriptable Objects/Narration/Dialogue/Dialogue")]
public class Dialogue : MonoBehaviour
{
    [SerializeField] private DialogueNode m_FirstNode;
    public DialogueNode FirstNode => m_FirstNode; //1
}
