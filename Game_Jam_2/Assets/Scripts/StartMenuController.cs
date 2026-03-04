using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("bora"); // byta sen till spelet
    }

    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // börja spelet om man trycker på "start"
#endif
        Application.Quit(); // om inte (trycker på exit) lämnar man spelet.
    }
}