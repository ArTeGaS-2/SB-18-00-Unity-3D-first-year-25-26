using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscMenu : MonoBehaviour
{
    public GameObject escMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escMenu.SetActive(!escMenu.activeSelf);
        }
    }
    public void ReturnButton()
    {
        escMenu.SetActive(!escMenu.activeSelf);
    }
    public void EscButtun()
    {
        Application.Quit();
    }
}
