using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;


public class ModuleMenu : MonoBehaviour
{
    public Button Module1;
    public Button Module2;
    public Button Module3;
    public Button Module4;

    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Module 1")
        {
            Debug.Log("Module 1 was clicked");
            GotoModule1();
        }
        else if (e.target.name == "Module 2")
        {
            Debug.Log("Module 2 was clicked");
            GotoModule2();
        }
        else if (e.target.name == "Module 3")
        {
            Debug.Log("Module 3 was clicked");
            GotoModule3();
        }
        else if (e.target.name == "Module 4")
        {
            Debug.Log("Module 4 was clicked");
            GotoModule4();
        }
    }

    public void GotoModule1()
    {
        SceneManager.LoadScene("Pick up cube & controller show");

    }

    public void GotoModule2()
    {
        SceneManager.LoadScene("Main");

    }

    public void GotoModule3()
    {
        SceneManager.LoadScene("final");

    }

    public void GotoModule4()
    {
        SceneManager.LoadScene("Game");

    }
}
