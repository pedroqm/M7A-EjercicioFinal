using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{

    public GameObject panelPausa;
    public GameObject panelGameOver;
    bool ispaused = false;
    
      void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }      
    }

    void Pausar()
    {
        Time.timeScale = 0f;
        panelPausa.SetActive(true);
        ispaused = true;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        panelPausa.SetActive(false);
        ispaused = false;
    }

    public void GameOver()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

        public void Restart()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1f;
        panelGameOver.SetActive(false);
    }
}
