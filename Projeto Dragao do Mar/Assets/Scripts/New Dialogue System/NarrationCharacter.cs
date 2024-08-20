using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Narration/Character")]
public class NarrationCharacter : ScriptableObject //2
{
    [SerializeField] private string m_CharacterName;
    public string CharacterName => m_CharacterName; //1
}
