using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Option()
    {

    }
    
    public void Exit()
    {
        Application.Quit();
    }


}
