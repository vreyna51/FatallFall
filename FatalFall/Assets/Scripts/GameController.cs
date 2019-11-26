using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCharacterSelector()
    {
        //SceneManager.LoadScene(x);
    }

    public void normal()
    {
        selectDifficulty(1);
    }

    public void hard()
    {
        selectDifficulty(2);
    }

    public void expert()
    {
        selectDifficulty(3);
    }

    void selectDifficulty(int difficulty)
    {
        //adjust features accordingly
        Debug.Log(difficulty);
    }

    public void LoadCredits()
    {
        //SceneManager.LoadScene(x);
    }

    public void LoadGameOver()
    {
        //SceneManager.LoadScene(x);
    }

    public void ClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Debug.Log("Quit the game.");

		Application.Quit();
#endif
    }
}
