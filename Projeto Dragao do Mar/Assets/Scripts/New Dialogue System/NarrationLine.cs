using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Narration/Line")]
public class NarrationLine : ScriptableObject //2
{
    [SerializeField] private NarrationCharacter m_Speaker;
    [SerializeField] private string m_Text;

    public NarrationCharacter Speaker => m_Speaker; //1
    public string Text => m_Text; //1
}
