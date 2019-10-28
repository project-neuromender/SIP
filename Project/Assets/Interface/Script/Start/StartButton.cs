using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class StartButton : MonoBehaviour
{
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("Connectlobby");
    }


}
