using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public static Economy Instance; // ѳ������

    public int clickCounter = 0; // ˳������� ����
    public TextMeshProUGUI clickCounterText; // ��'��� ������ �� ����

    public float coinsPerClick = 1; // ����� �� ���
    public TextMeshProUGUI coinsPerClickText;

    private void Start()
    {
        Instance = this;
    }
    private void UpdateText()
    {
        clickCounterText.text = "������: " + clickCounter.ToString();
    }
}
