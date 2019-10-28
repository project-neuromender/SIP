using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class TextInstructions : MonoBehaviour
{
    public Text changingText;
    public Button NextButton;
    public Button BackButton;
    public int counter = 1;

    public void changeText()
    {
        
        if (counter == 1)
        {
            counter++;
            changingText.text = "STEP 1:" + System.Environment.NewLine + "Put the circle-like component on plane." + System.Environment.NewLine + System.Environment.NewLine + "Click 'Next' to continue.";
        }
        else if (counter == 2)
        {
            counter++;
            changingText.text = "STEP 2:" + System.Environment.NewLine + "Screw the circle-like component to the plane with screws provided." + System.Environment.NewLine + System.Environment.NewLine + "Click 'Next' to continue.";
        }
        else if (counter == 3)
        {
            changingText.text = "Step 3: " + System.Environment.NewLine + "Put Adils at the centre of circle-like component and rotate it. " + System.Environment.NewLine + System.Environment.NewLine + " Step completed";
            //NextButton.interactable = false;
        }
    }

    public void changeToPrevText()
    {
        if (counter == 1)
        {
            changingText.text = "STEP 1:" + System.Environment.NewLine + "Put the circle-like component on plane." + System.Environment.NewLine + System.Environment.NewLine + "Click 'Next' to continue.";
            //BackButton.interactable = false;
        }
        else if (counter == 2)
        {
            counter--;
            changingText.text = "STEP 2:" + System.Environment.NewLine + "Screw the circle-like component to the plane with screws provided." + System.Environment.NewLine + System.Environment.NewLine + "Click 'Next' to continue.";
        }
        else if (counter == 3)
        {
            counter--;
            changingText.text = "Step 3: " + System.Environment.NewLine + "Put Adils at the centre of circle-like component and rotate it. " + System.Environment.NewLine + System.Environment.NewLine + " Step completed";
            //NextButton.interactable = false;
        }
    }
}


