using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerCount : MonoBehaviour
{
    public static int bottleCount, totalCount = 2;
    public static bool hasKilledAll = false;

    public static void KillCountUp()
    {
        bottleCount++;
        if (bottleCount >= totalCount)
        {
            hasKilledAll = true;
        }
    }
}
