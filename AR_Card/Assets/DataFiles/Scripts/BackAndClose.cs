using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndClose : MonoBehaviour
{
    public void backBtn()
    {
        SceneManager.LoadScene("Menu_Scene");
    }
    public void exitBtn()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Exit Button Pressed");
    }
}
