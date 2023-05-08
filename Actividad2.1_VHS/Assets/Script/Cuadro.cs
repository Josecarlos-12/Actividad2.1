using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cuadrado : Figura
{
    [SerializeField] private TMP_InputField squareLInput;

    protected override float GetArea()
    {
        float l = float.Parse(squareLInput.text);
        return l * l;
    }

}
