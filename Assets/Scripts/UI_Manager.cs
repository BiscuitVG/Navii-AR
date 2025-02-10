using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject welcomeScreen; // Reference to the first screen
    public GameObject loginScreen; // Reference to the login screen for registered users

    // This function will show the welcome screen and hide the login screen
    public void showWelcomeScreen()
    {
        welcomeScreen.SetActive(true);
        loginScreen.SetActive(false);
    }

    // This function will show the login screen and hide the welcome screen
    public void showLoginScreen()
    {
        Debug.Log("Login button has been clicked!");
        welcomeScreen.SetActive(false);
        loginScreen.SetActive(true);
    }
}