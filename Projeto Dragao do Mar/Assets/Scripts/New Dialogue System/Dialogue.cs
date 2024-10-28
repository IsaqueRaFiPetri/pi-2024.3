using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name; // Nome do NPC ou do di�logo
    [TextArea(5, 12)]
    public string[] sentences; // Frases do di�logo
    public DialogueOption[] options; // Op��es de resposta
    public bool hasGivedPoints;
    public int pointsToGive;
    public bool isPartOfQuests;
    public NpcFunctions npcFunctions;
}