using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseClick : MonoBehaviour
{
    private int clickCounter; // Лічильник кілків
    private TextMeshProUGUI textObj; // Об'єкт тексту на сцені

    private bool buttonPressStatus = false;
    private void Start()
    {
        // Беремо значення з Economy
        clickCounter = Economy.Instance.clickCounter;
        textObj = Economy.Instance.clickCounterText;
    }
    private void OnMouseDown()
    {
        ClickButton();
        ClickImpactEffect();
    }
    private void OnMouseUp()
    {
        DisableClickImpactEffect();
    }
    private void ClickButton()
    {
        clickCounter++; // + 1 До значення лічильника
        textObj.text = "Монети: " + clickCounter.ToString();
    }
    private void ClickImpactEffect()
    {
        if (buttonPressStatus == false)
        {
            // Зміна позиції циліндра при натисканні
            transform.localPosition = new Vector3(0, 0.3f, 0);
            buttonPressStatus = true;
        }
    }
    private void DisableClickImpactEffect()
    {
        if (buttonPressStatus == true)
        {
            // Зміна позиції циліндра при натисканні
            transform.localPosition = new Vector3(0, 0.5f, 0);
            buttonPressStatus = false;
        }
    }
}
