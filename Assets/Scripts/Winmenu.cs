using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winmenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
    public void menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
      public void QuitGame()
    {
        Application.Quit();
    }
}
