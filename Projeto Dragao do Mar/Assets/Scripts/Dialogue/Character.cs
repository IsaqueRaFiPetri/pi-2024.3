using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public static Character instance;
    public string nome;
    public Sprite charcterImage;

    [TextArea(3, 10)]
    public string[] sentences;

    void Start()
    {
        instance = this;
    }

}
