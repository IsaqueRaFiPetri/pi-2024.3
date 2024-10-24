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
        UpdateNPCState();       // Inicialmente, o NPC antes da quest está ativo, e o NPC depois da quest está desativado
    }

    // Método para atualizar o estado dos NPCs conforme o progresso da quest
    public void CompleteQuest()
    {
        isQuestComplete = true;
        UpdateNPCState();
    }

    void UpdateNPCState()   // Se a quest está completa, mostra o NPC pós-quest, senão mostra o NPC pré-quest
    {
        npcBeforeQuest.SetActive(!isQuestComplete);
        npcAfterQuest.SetActive(isQuestComplete);
    }

}
