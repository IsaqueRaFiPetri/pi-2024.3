using UnityEngine;

public class Changer : InteractableObject
{
    bool hasChanged;
    public GameObject espaco;
    public GameObject cheio;

    protected override void Interact()
    {
        espaco.SetActive(false);
        cheio.SetActive(true);

        hasChanged = true;

        Verificatoer.CheckUp();
    }
}
