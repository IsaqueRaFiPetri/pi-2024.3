using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Target : MonoBehaviour
{
    public float health;

    public void TakeDamage(int damage)
    {
        print("tomou dano");
        health -= damage;
        if (health < 0)
        {
            Destroy(gameObject, 0.5f);
        }

        Destroy(gameObject, 0.5f);
    }

}
