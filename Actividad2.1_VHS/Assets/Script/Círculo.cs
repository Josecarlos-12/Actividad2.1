using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Círculo : Figura
{
    [SerializeField] private TMP_InputField circleRInput;

    protected override float GetArea()
    {
        float r = float.Parse(circleRInput.text);
        return 3.14f * (r * 2);
    }
}
