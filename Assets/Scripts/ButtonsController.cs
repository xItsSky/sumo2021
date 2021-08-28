using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("SamScene");
    }
    public void Option()
    {
        EventSystem.current.SetSelectedGameObject(GameObject.Find("Option Menu/Return button"));
    }

    public void Credit()
    {
        EventSystem.current.SetSelectedGameObject(GameObject.Find("Credits Menu/Return button"));
    }

    public void Back()
    {
        EventSystem.current.SetSelectedGameObject(GameObject.Find("Main Menu/Play Button"));
    }


    public void Exit()
    {
        Application.Quit();
    }


}
