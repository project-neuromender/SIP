using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.UI;
using Photon.Pun;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private Text _text;

    public SteamVR_LaserPointer laserPointer;

    //public GameObject PanelTesting;


    /*void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }*/

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "ScrollView")
        {
            Debug.Log("Room Listing was clicked");
            OnClick_Button();
        }
       
    }

    public RoomInfo RoomInfo { get; private set; }
    
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        _text.text = roomInfo.MaxPlayers + " , " + roomInfo.Name;
    }

    public void OnClick_Button()
    {
        PhotonNetwork.JoinRoom(RoomInfo.Name);
        Debug.Log("Room Listing Menu : Join Room");
    }
}
