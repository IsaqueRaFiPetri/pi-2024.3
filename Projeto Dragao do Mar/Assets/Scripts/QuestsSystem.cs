using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsSystem : MonoBehaviour
{
    public GameObject npcBeforeQuest;
    public GameObject npcAfterQuest;
    public bool isQuestComplete = false;

    void Start()
    { 
        UpdateNPCState();       // Inicialmente, o NPC antes da quest est� ativo, e o NPC depois da quest est� desativado
    }

    // M�todo para atualizar o estado dos NPCs conforme o progresso da quest
    public void CompleteQuest()
    {
        isQuestComplete = true;
        UpdateNPCState();
    }

    void UpdateNPCState()   // Se a quest est� completa, mostra o NPC p�s-quest, sen�o mostra o NPC pr�-quest
    {
        npcBeforeQuest.SetActive(!isQuestComplete);
        npcAfterQuest.SetActive(isQuestComplete);
    }

}
