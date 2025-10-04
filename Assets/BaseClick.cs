using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseClick : MonoBehaviour
{
    public int clickCounter = 0; // Лічильник кілків
    public TextMeshProUGUI textObj; // Об'єкт тексту на сцені
    private void OnMouseDown()
    {
        clickCounter++; // + 1 До значення лічильника
        textObj.text = "Монети: " + clickCounter.ToString();
    }
}
