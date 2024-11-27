using UnityEngine;

public class Verificatoer : MonoBehaviour
{
    public QuestsSystem QuestsSystem;

    public static bool hasCheckedAll;
    public static int paper, totalPapers = 4;

    // Update is called once per frame
    void Update()
    {
        if (hasCheckedAll)
        {
            QuestsSystem.CompleteQuest();
        }
    }

    public static void CheckUp()
    {
        paper++;
        if (paper >= totalPapers)
        {
            hasCheckedAll = true;
        }
    }
}
