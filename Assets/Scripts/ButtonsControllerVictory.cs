using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsControllerVictory : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene("SamScene");
    }

    // Update is called once per frame
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
