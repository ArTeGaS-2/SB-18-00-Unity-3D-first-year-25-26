using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance; // Сінглтон

    public int clickCounter = 0; // Лічильник кліків
    public TextMeshProUGUI clickCounterText; // Об'єкт тексту на сцені

    public float coinsPerClick = 1; // Монет за клік
    public TextMeshProUGUI coinsPerClickText;

    private void Start()
    {
        Instance = this;
    }
    private void UpdateText()
    {
        clickCounterText.text = "Монети: " + clickCounter.ToString();
    }
}
