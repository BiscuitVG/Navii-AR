using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void loadNavigationScene()
    {
        Debug.Log("Guest button has been clicked!");
        SceneManager.LoadScene("NavigationScene");
    }
}