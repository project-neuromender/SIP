using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Testing : MonoBehaviour
{
    private RoomCanvases _roomCanvas;
    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Keyboard")
        {
            Debug.Log("Keyboard was clicked");
        }
        else if (e.target.name == "StartGame")
        {
            Debug.Log("Button was clicked : Module");
            OnClick_StartGame();
        }
    }


    public void FirstInitialize(RoomCanvases canvases)
    {
        _roomCanvas = canvases;
    }

    public void OnClick_StartGame()
    {
        PhotonNetwork.LoadLevel("GameMenu");
    }
}
