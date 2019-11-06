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

    private string roomname;

    public RoomInfo RoomInfo { get; private set; }
    
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        _text.text = roomInfo.MaxPlayers + " , " + roomInfo.Name;

        roomname = roomInfo.Name;

        Debug.Log("Room Name : " + roomname);
    }

    public void OnClick_Button()
    {
        //Debug.Log("Room Name : " + RoomInfo.Name);
        //Debug.Log("Room Name : " + roomname);

        //Debug.Log("Joining room in the list");
        //PhotonNetwork.JoinRoom(roomname);
        //Debug.Log("Room Listing Menu : Join Room");
    }
}
