using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class ImageInstructions : MonoBehaviour
{
    public Sprite[] frames;                // array of textures
    public Image image;


    public Button NextButton;
    public Button BackButton;
    public int counter = 0;


    public void LoadSprite()
    {
        counter++;
        if (counter == 1)
        {
            image.sprite = frames[0]; //Change The Image
        }
        else if (counter == 2)
        {
            image.sprite = frames[1]; //Change The Image

        }
        else if (counter == 3)
        {
            image.sprite = frames[2]; //Change The Image
        }
        else if (counter == 4)
        {
            image.sprite = frames[3]; //Change The Image
        }
        else if (counter == 5)
        {
            image.sprite = frames[4]; //Change The Image
        }
        else if (counter == 6)
        {
            image.sprite = frames[5]; //Change The Image
        }
        else if (counter == 7)
        {
            image.sprite = frames[6]; //Change The Image
        }
        else if (counter == 8)
        {
            //NextButton.interactable = true;
            image.sprite = frames[7]; //Change The Image
        }
        else
        {
            image.sprite = frames[8]; //Change The Image
            //NextButton.interactable = false;
        }
    }

    public void LoadPrevSprite()
    {
        if (counter == 1)
        {
            image.sprite = frames[0]; //Change The Image
            //BackButton.interactable = false;

        }
        else if (counter == 2)
        {
            counter--;
            //BackButton.interactable = true;
            image.sprite = frames[1]; //Change The Image
        }
        else if (counter == 3)
        {
            counter--;
            image.sprite = frames[2]; //Change The Image
        }
        else if (counter == 4)
        {
            counter--;
            image.sprite = frames[3]; //Change The Image
        }
        else if (counter == 5)
        {
            counter--;
            image.sprite = frames[4]; //Change The Image
        }
        else if (counter == 6)
        {
            counter--;
            image.sprite = frames[5]; //Change The Image
        }
        else if (counter == 7)
        {
            counter--;
            image.sprite = frames[6]; //Change The Image
        }
        else if (counter == 8)
        {
            counter--;
            image.sprite = frames[7]; //Change The Image
        }
        else
        {
            counter--;
            image.sprite = frames[8]; //Change The Image
            //NextButton.interactable = false;
        }
    }
}

