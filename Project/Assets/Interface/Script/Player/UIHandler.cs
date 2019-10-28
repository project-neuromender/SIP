using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class UIHandler : MonoBehaviourPunCallbacks
{
    public InputField CreateRoomTF;
    public InputField JoinRoomTF;
    private string playerName;
    private string roomName;

    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    public void SetRoomName(string name)
    {
        roomName = name;
    }

    public void OnClick_JoinRoom()
    {
        PhotonNetwork.JoinRoom(JoinRoomTF.text,null);
    }

    public void OnCLick_CreateRoom()
    {
        PhotonNetwork.CreateRoom(CreateRoomTF.text, new RoomOptions { MaxPlayers = 4 }, null);
        Debug.Log("Create Room Success : " + CreateRoomTF.text);

    }

    public override void OnJoinedRoom()
    {

        if (PhotonNetwork.IsConnected)
        {
            print("Join Room Success");
            PhotonNetwork.LoadLevel(1);
        }


       // print("Join Room Success");
        //PhotonNetwork.LoadLevel(1);
        
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        print("RoomFailed" + returnCode + "Message: " +message);
    }

    
}
