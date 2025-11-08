using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance; // Сінглтон

    [Header("Лічильник")]
    public float clickCounter = 0f; // Лічильник кліків
    public float coinsPerClick = 1f; // Монет за клік

    [Header("Бонус")]
    public float clickBonusPrice = 10f; // Базова ціна
    public float clickBonusPriceMod = 15f; // модифікатор ціни

    [Header("Текстові елементи")]
    public TextMeshProUGUI clickCounterText; // Об'єкт тексту на сцені
    public TextMeshProUGUI coinsPerClickText; // " X за клік"

    private void Start()
    {
        Instance = this;
    }
    public void UpdateText()
    {
        clickCounterText.text = "Монети: " + clickCounter.ToString();
    }
    public float TakeCurrentPrice()
    {
        // дробове ціна = цінаБонусуКліку + (монетЗаКлік - 1) * модифікаторЦіни
        float price =
            clickBonusPrice + (coinsPerClick - 1) * clickBonusPriceMod;
        return price;
    }
}
