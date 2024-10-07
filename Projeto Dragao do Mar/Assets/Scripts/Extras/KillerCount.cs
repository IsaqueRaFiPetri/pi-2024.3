using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillerCount : MonoBehaviour
{
    public static int bottleCount, totalCount = 2;
    public static bool hasKilledAll = false;

    public TextMeshProUGUI text;

    private void Update()
    {
        text.SetText(bottleCount + " / " + totalCount);
    }
    public static void KillCountUp()
    {
        bottleCount++;
        if (bottleCount >= totalCount)
        {
            hasKilledAll = true;
        }
    }
}
