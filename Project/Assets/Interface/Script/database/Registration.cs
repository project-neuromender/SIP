using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Registration : MonoBehaviour
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
        if (e.target.name == "BackButton")
        {
            Debug.Log("Back button was clicked");
            OnClick_ButtonBack();
        }
        if (e.target.name == "RegisterButton")
        {
            Debug.Log("Register was clicked");
            CallRegister();
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }

    public void OnClick_ButtonBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    [System.Obsolete]
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);

        WWW www = new WWW("http://localhost/sqlconnect/Registration.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User created successfully.");
            SceneManager.LoadScene("LoginMenu");
        }

        else
        {
            Debug.Log("User creation failed. Error #" + www.text);
            playerDisplay.text = "User creation failed." + www.text;
        }
    }
}