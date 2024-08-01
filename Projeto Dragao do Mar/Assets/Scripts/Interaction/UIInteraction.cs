using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteraction : InteractableObject
{
    public GameObject painel;

    protected override void Interact()
    {
        PlayerInteraction.Instance.OnInteractionEffected.Invoke();
        painel.SetActive(true);
        PlayerStats.instance.SetUIingMode();
    }
}
