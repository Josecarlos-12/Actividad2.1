using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Triángulo : Figura
{
    [SerializeField] private TMP_InputField triangleBInput;
    [SerializeField] private TMP_InputField triangleHInput;

    protected override float GetArea()
    {
        float b = float.Parse(triangleBInput.text);
        float h = float.Parse(triangleHInput.text);
        return b * h / 2;
    }
}