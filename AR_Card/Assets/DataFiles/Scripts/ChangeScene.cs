using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
   public void greeting()
    {
        SceneManager.LoadScene("AR_Card_Scene");
    }
    public void rotateCube()
    {
        SceneManager.LoadScene("Cube_Scene");
    }
    public void exitGame()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Exit Button Pressed");
    }
}
