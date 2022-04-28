using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private bool win = false;
    public Button[] buttons;

    private void Update()
    {
        winGame();
        for (int i = 0; i < buttons.Length; i++)
        {
            if(i + 6 > PlayerPrefs.GetInt("faseComplatada"))
            {
                buttons[i].interactable = false;
            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("win") == true)
        {
            win = true;
        }
    }

    void winGame()
    {
        if(win == true)
        {
            if(SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("faseCompletada"))
            {
                PlayerPrefs.SetInt("faseCompletada", SceneManager.GetActiveScene().buildIndex);
                PlayerPrefs.Save();
            }
        }
    }
    /*public void callLevels()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("faseAtual") + 1);
    }*/
}
