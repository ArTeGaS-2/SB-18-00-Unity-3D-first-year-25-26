using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BaseClick : MonoBehaviour
{
    public int clickCounter = 0; // ˳������� ����
    public TextMeshProUGUI textObj; // ��'��� ������ �� ����

    private bool buttonPressStatus = false;
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
        clickCounter++; // + 1 �� �������� ���������
        textObj.text = "������: " + clickCounter.ToString();
    }
    private void ClickImpactEffect()
    {
        if (buttonPressStatus == false)
        {
            // ���� ������� ������� ��� ���������
            transform.localPosition = new Vector3(0, 0.3f, 0);
            buttonPressStatus = true;
        }
    }
    private void DisableClickImpactEffect()
    {
        if (buttonPressStatus == true)
        {
            // ���� ������� ������� ��� ���������
            transform.localPosition = new Vector3(0, 0.5f, 0);
            buttonPressStatus = false;
        }
    }
}
