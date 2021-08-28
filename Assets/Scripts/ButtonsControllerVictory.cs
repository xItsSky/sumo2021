using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonsControllerVictory : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Sprite> listSprites;
    public Image WinneRenderer;
    public TextMeshProUGUI TextMeshPro;

    void Start()
    {
        WinnerEnum winner = Winner.winner;
        WinneRenderer.sprite = listSprites[(int)winner];
        string messageWin = "Player ";
        if (winner == WinnerEnum.BLUE)
        {
            messageWin += "BLUE ";
            TextMeshPro.color = Color.blue;
        }
        else
        {
            messageWin += "RED ";
            TextMeshPro.color = Color.red;
        }

        messageWin += "win ! Congratulations !";
        TextMeshPro.text = messageWin;
    }

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
