﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CepuresMainisana : MonoBehaviour
{
    [Header("Sprite to change")]
    public SpriteRenderer bodyPart;

    [Header("Sprite to cycle trough")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }

        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }
        bodyPart.sprite = options[currentOption];
    }
}
