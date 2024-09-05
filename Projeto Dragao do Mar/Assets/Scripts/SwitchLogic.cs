using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchLogic : MonoBehaviour
{
    bool isTurned, canTurn;

    private void Start()
    {
        isTurned = false;
        canTurn = true;
    }
    private void OnMouseDown()
    {
        if(canTurn)
        {
            canTurn = false;
            if (isTurned == false)
            {
                GetComponent<Animation>().Play("Alavanca_CimaBaixo");
                StartCoroutine(Change());
            }
            else
            {
                GetComponent<Animation>().Play("Alavanca_BaixoCima");
                StartCoroutine(Change());
            }
        }
    }

    IEnumerator Change()
    {
        yield return new WaitForSeconds(0.417f);
        canTurn = true;
        isTurned = !isTurned;
    }
}
// https://www.youtube.com/watch?v=UEP6DdCbaK8