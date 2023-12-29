using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bringUpSetting : MonoBehaviour
{
    public GameObject setting;
    public bool issettingactive;
    public Controller controller;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (issettingactive == false)
            {
                Pause();
            }

            else
            {
                Resume();
            }
        }
    }
    public void Pause()
    {
        setting.SetActive(true);
        issettingactive = true;
        controller.enabled = false;
        //if an error occurs make sure to delete and then add your own＜＞(Youtube doesn't allow angled brackets in the comments for some reason)
        Cursor.lockState = CursorLockMode.None;
    }

    public void Resume()
    {
        setting.SetActive(false);
        issettingactive = false;
        //if an error occurs make sure to delete and then add your own＜＞(Youtube doesn't allow angled brackets in the comments for some reason)
        controller.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
