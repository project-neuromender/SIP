using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button registerButton;
    public Button loginButton;
    public Button playButton;

    public Text playerDisplay;

    private void Start()
    {
        if(DBManager.LoggedIn)
        {
            playerDisplay.text = "Click Lobby to Start";
        }
        

        registerButton.interactable = !DBManager.LoggedIn;
        loginButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;
    }

    public void GotoRegister()
    {
        SceneManager.LoadScene("RegisterMenu");

    }

    public void GotoLogin()
    {
        SceneManager.LoadScene("LoginMenu");
    }

    public void GotoGame()
    {
        SceneManager.LoadScene("Connectlobby");
    }
}
