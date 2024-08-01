using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

enum verifier
{
    none, wrong, correct
}
public class Verifier : MonoBehaviour
{
    public static Verifier Instance;
    public int correctDropdowns, currentDropdowns;
    public UnityEvent Correct, Wrong, Verify;

    public void Awake()
    {
        currentDropdowns = 0;
        Instance = this;
    }
    public void VerifyCall()
    {
        Verify.Invoke();
    }
    public void verifier()
    {
        if (currentDropdowns >= correctDropdowns)
        {
            Correct.Invoke();
            Debug.Log("Est� Correto");
        }
        else
        {
            Wrong.Invoke();
            Debug.Log("Est� Incorreto");
        }
    }
}
