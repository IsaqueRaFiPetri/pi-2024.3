using UnityEngine;
using UnityEngine.Events;

public class PlayerInteraction : MonoBehaviour
{
    public static PlayerInteraction Instance;
    public UnityEvent OnInteractionEffected;
    Transform cam;
    public float handDistance = 3;
    public GameObject interactionInstruction;
    
    void Start()
    {
        Instance = this;
        cam = Camera.main.transform;
    }

    public void RayCast()
    {
        RaycastHit hit;
        Debug.DrawRay(cam.position, cam.forward * handDistance, Color.blue);
        if (Physics.Raycast(cam.position, cam.forward, out hit, handDistance))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                hit.collider.SendMessage("Interact", SendMessageOptions.DontRequireReceiver);
                //print(hit.collider.name);
            }
            if(hit.collider.CompareTag("Interagivel"))
            interactionInstruction.SetActive(true);
        }
        else
        {
            interactionInstruction.SetActive(false);
        }
    }
}