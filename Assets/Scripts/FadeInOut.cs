using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image Image;
    private AsyncOperation menu;

    IEnumerator Start() {
        menu = SceneManager.LoadSceneAsync("Menu");
        menu.allowSceneActivation = false;
        Image.canvasRenderer.SetAlpha(0.0f);
        yield return new WaitForSeconds(1.0f);
        FadeIn();
        yield return new WaitForSeconds(4.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        menu.allowSceneActivation = true;
    }

    void FadeIn() {
        Image.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut() {
        Image.CrossFadeAlpha(0.0f, 1.5f, false);
    }
}
