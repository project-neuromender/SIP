using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;
    public Text playerDisplay;

    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "LoginButton")
        {
            Debug.Log("Login button clicked");
            CallLogin();
        }
        else if (e.target.name == "BackButton")
        {
            Debug.Log("Going back");
            OnClick_BackButton();
        }
    }

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    [System.Obsolete]
    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);

        WWW www = new WWW("http://localhost/sqlconnect/Login.php", form);
        yield return www;
        if (www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.score = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User login failed.Error #" + www.text);
            playerDisplay.text = "User login failed. Error #" + www.text;
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }

    public void OnClick_BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
