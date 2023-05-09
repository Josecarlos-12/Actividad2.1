using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ControladorForma
{
    [SerializeField] private Button shapeButton;
    [SerializeField] private GameObject shapeContainerGameObject;
    [SerializeField] private GameObject question;
    [SerializeField] private GameObject result;
    [SerializeField] private Figura figura;
    [SerializeField] private GameObject newQuestion;
    [SerializeField] private Button buttonFinal;
    [SerializeField] private GameObject panelFinal;
    [SerializeField] private Button newShape;

    public void Init(Action<float> callback)
    {
        shapeButton.onClick.AddListener(() =>
        {
            Show();
            figura = shapeContainerGameObject.GetComponent<Figura>();
            figura.Init(callback);
        });

        buttonFinal.onClick.AddListener(() =>
        {
            shapeContainerGameObject.SetActive(false);
            result.SetActive(false);
            newQuestion.SetActive(false);
            panelFinal.SetActive(true);
            result.GetComponent<TextMeshProUGUI>().text = "El resultado es";
        });

        newShape.onClick.AddListener(() =>
        {
            shapeContainerGameObject.SetActive(false);
            result.SetActive(false);
            newQuestion.SetActive(false);
            question.SetActive(true);
            result.GetComponent<TextMeshProUGUI>().text = "El resultado es";
        });
    }

    public void NewQuestion()
    {
        newQuestion.SetActive(true);
    }

    private void Show()
    {
        shapeContainerGameObject.SetActive(true);
        question.SetActive(false);
        result.SetActive(true);
    }

}
