using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rect�ngulo : Figura
{
    [SerializeField] private TMP_InputField rectangleBInput;
    [SerializeField] private TMP_InputField rectangleHInput;

    protected override float GetArea()
    {
        float b = float.Parse(rectangleBInput.text);
        float h = float.Parse(rectangleHInput.text);
        return b * h;
    }
}