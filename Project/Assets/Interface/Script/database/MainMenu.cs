using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class MainMenu : MonoBehaviour
{
    public Button registerButton;
    public Button loginButton;
    public Button playButton;

    public Text playerDisplay;

    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Click Lobby to Start";
        }


        registerButton.interactable = !DBManager.LoggedIn;
        loginButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Register")
        {
            Debug.Log("Register was clicked");
            GotoRegister();
        }
        else if (e.target.name == "Login")
        {
            Debug.Log("Login was clicked");
            GotoLogin();
        }
        else if (e.target.name == "Lobby")
        {
            Debug.Log("Lobby was clicked");
            GotoGame();
        }
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
