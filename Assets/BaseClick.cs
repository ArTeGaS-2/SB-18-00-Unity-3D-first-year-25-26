using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseClick : MonoBehaviour
{
    public int clickCounter = 0; // ˳������� ����
    public TextMeshProUGUI textObj; // ��'��� ������ �� ����
    private void OnMouseDown()
    {
        clickCounter++; // + 1 �� �������� ���������
        textObj.text = "������: " + clickCounter.ToString();
    }
}
