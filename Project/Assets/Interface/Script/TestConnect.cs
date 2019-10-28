using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private RoomCanvases _roomCanvases;
    public Text Status;

    // Start is called before the first frame update
    /*void Start()
    {
        Debug.Log("Connecting to Server...");
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = MasterManager.GameSettings.Nickname;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }
    

    public override void OnConnecttoServer()
    {        
        //MasterManager.DebugConsole.AddText("Connected to Photon", this);
        Debug.Log("Connected to Self-hosted server", this);
        Debug.Log("My Nickname is " + PhotonNetwork.LocalPlayer.NickName, this);
        //if (!PhotonNetwork.InLobby)
       // {
            //PhotonNetwork.JoinLobby();
            PhotonNetwork.JoinLobby(TypedLobby.Default);
        //}
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Failed to connect to Self-hosted server " + cause.ToString(), this);
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined lobby.");
    }*/

    private void Start()
    {
        Debug.Log("Connecting to Server...");
        Status.text = "Connecting to Server...";
        PhotonNetwork.NickName = MasterManager.GameSettings.Nickname;
        PhotonNetwork.ConnectUsingSettings();
    }

    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Player Name : " + PhotonNetwork.NickName);
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }
 

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Failed to connect to Self-hosted server " + cause.ToString(), this);
        Status.text = "Failed to connect to Self-hosted server";
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined lobby.");
        Status.text = "Joined lobby.";
    }
}
