using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    public GameObject world_G_Obj; // об'Їкти гри у св≥т≥
    public GameObject UI_G_Obj; // об'Їкти гри у UI

    public GameObject world_S_Obj; // об'Їкти магазину у св≥т≥
    public GameObject UI_S_Obj; // об'Їкти магазину у UI
    public void SwitchSceneButton()
    {
        // ќб'Їкт.«м≥на—тану(!ќб'Їкт.поточний—тан);
        world_G_Obj.SetActive(!world_G_Obj.activeSelf);
        UI_G_Obj.SetActive(!UI_G_Obj.activeSelf);

        world_S_Obj.SetActive(!world_S_Obj.activeSelf);
        UI_S_Obj.SetActive(!UI_S_Obj.activeSelf);
    }
}
