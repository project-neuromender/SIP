using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    public InputField _RoomName;
    public InputField _JoinRoom;
    private GameObject ScrollView;

    public Text _PlayerNickname;
   
    private RoomCanvases _roomCanvases;
    public SteamVR_LaserPointer laserPointer;

    void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            _PlayerNickname.text = "Player Nickname : " + PhotonNetwork.NickName;
        }
    }

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
        else if (e.target.name == "CreateRoom")
        {
            Debug.Log("Button was clicked : Create Room Menu");
            OnClick_CreateRoom();
        }
        else if (e.target.name == "JoinRoom")
        {
            Debug.Log("Button was clicked : Create Room Menu");
            OnClick_JoinRoom();
        }        
    }

    public void FirstInitialize(RoomCanvases canvases)
    {
        _roomCanvases = canvases;
    }
    

    /*public void OnCLick_JoinRoom()
    {
        //what the controller click 
    }*/

    public void OnClick_CreateRoom()
    {
        Debug.Log("Creating room ");

        if (PhotonNetwork.IsConnected)
        {
            //return;

            PhotonNetwork.CreateRoom(_RoomName.text, new RoomOptions { MaxPlayers = 4 }, null);
            Debug.Log("Create Room success" + _RoomName.text );
            //PanelTesting.SetActive(true);
            //_roomCanvases.CurrentRoomCanvas.Show();


        }
        /*RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(_RoomName.text, options, TypedLobby.Default);*/
    }

    public void OnClick_JoinRoom()
    {
        PhotonNetwork.JoinRoom(_JoinRoom.text,null);
        Debug.Log("Join Room Success !");

    }

    public override void OnCreatedRoom()
   {
       Debug.Log("Created room successfully.", this);
       _roomCanvases.CurrentRoomCanvas.Show();
   }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Creation room failed."  + message, this);
    }
}
