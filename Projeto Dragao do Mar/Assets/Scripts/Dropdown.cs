using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : MonoBehaviour
{
    public int correctValue, currentValue;
    bool correct;
    public void DropDown(int i)
    {
        currentValue = i;
        if (currentValue == correctValue)
        {
            correct = true;
        }
        else
        correct = false;
    }
    public void Verify()
    {
        if (correct)
        {
            Verifier.Instance.currentDropdowns++;
        }
    }
}
