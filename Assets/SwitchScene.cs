using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    public GameObject world_G_Obj; // ��'���� ��� � ���
    public GameObject UI_G_Obj; // ��'���� ��� � UI

    public GameObject world_S_Obj; // ��'���� �������� � ���
    public GameObject UI_S_Obj; // ��'���� �������� � UI
    public void SwitchSceneButton()
    {
        // ��'���.���������(!��'���.������������);
        world_G_Obj.SetActive(!world_G_Obj.activeSelf);
        UI_G_Obj.SetActive(!UI_G_Obj.activeSelf);

        world_S_Obj.SetActive(!world_S_Obj.activeSelf);
        UI_S_Obj.SetActive(!UI_S_Obj.activeSelf);
    }
}
