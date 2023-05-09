using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    [SerializeField] private List<ControladorForma> shapeControllerList;
    [SerializeField] protected TextMeshProUGUI resultText;

    void Start()
    {
        foreach (var shapeController in shapeControllerList)
        {
            shapeController.Init(ShowResult);
        }
    }

    private void ShowResult(float result)
    {
        resultText.text = $"El resultado es {result}";
        Debug.Log("Resultado");

        foreach (var shapeController in shapeControllerList)
        {
            shapeController.NewQuestion();
        }
    }
}