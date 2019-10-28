using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;
    public Text playerDisplay;

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

        WWW www = new WWW("http://localhost/sqlconnect/Registration.php",form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User created successfully.");
            SceneManager.LoadScene(0);
        }

        else
        {
            Debug.Log("User creation failed. Error #" + www.text);
            playerDisplay.text = "User creation failed." + www.text;
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
}
