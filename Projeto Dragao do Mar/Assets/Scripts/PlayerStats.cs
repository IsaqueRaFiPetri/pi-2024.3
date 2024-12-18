using UnityEngine;
using UnityEngine.Events;

public enum PlayerModes
{
    Walking, UIing
}

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    PlayerModes modes;
    FirstPersonController controller;
    public static int politicalPoints, politicsPointsToConclude = 58;

    public UnityEvent OnPause, OnUnpause;

    internal Vector3 velocity;
    Vector2 look;
    public GameObject player;

    void Awake()
    {
        instance = this;
        controller = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        //print(politicalPoints);

        switch (modes)
        {
            case PlayerModes.Walking:
                controller.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                PlayerInteraction.Instance.enabled = true;
                PlayerInteraction.Instance.RayCast();
                break;
            case PlayerModes.UIing:
                controller.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                PlayerInteraction.Instance.enabled = false;
                break;
        }
        PauseControl();
    }

    public void PauseControl()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                modes = PlayerModes.UIing;
                OnPause.Invoke();
            }
            else
            {
                Time.timeScale = 1;
                modes = PlayerModes.Walking;
                OnUnpause.Invoke();
            }
        }
    }
    public static void GainPoints(int politcPoints)
    {
        politicalPoints += politcPoints;
        HUD.instance.SetPoints();
        if(politicalPoints >= politicsPointsToConclude)
        {
            HUD.instance.conclusionPainel.SetActive(true);
        }
    }

    public void SetPause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    public void SetUIingMode()
    {
        modes = PlayerModes.UIing;
    }
    public void SetWalkingMode()
    {
        modes = PlayerModes.Walking;
    }
    public void Teleport(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        //player.Transform.Rotate;
        Physics.SyncTransforms();
        look.x = rotation.eulerAngles.x;
        look.y = rotation.eulerAngles.z;
        velocity = Vector3.zero;
    }
}
 