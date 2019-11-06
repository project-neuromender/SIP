using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private string _gameVersion = "0.0.0";

    public Text Status;
    public Text _playerName;

    //public Text playername;

    string roomName = "My Room";
    bool ShowGUI = true;

    public SteamVR_LaserPointer laserPointer;
    

    public void OnClick_ConnectBtn()
    {
        Debug.Log("Connecting to Server...");
        Status.text = "Connecting to Server...";
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = _playerName.text;
        Debug.Log(PhotonNetwork.NickName);
        PhotonNetwork.GameVersion = _gameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }

    

    private void Awake()
    {
        laserPointer.PointerClick += PointerClick;

        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Keyboard")
        {
            Debug.Log("Keyboard was clicked");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was clicked");
            OnClick_ConnectBtn();
        }
    }

    public override void OnConnectedToMaster()
    {
        //MasterManager.DebugConsole.AddText("Connected to Photon", this);
        Debug.Log("Connected to Self-hosted server", this);
        Status.text = "Connected to Self-hosted server.";
        Debug.Log("My Nickname is " + PhotonNetwork.LocalPlayer.NickName, this);
        Status.text = "My Nickname is " + PhotonNetwork.LocalPlayer.NickName;
        

        if (!PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinLobby(TypedLobby.Default);
        }
    }

    

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Failed to connect to Self-hosted server " + cause.ToString(), this);
        Status.text = "Failed to connect to Self-hosted server." + cause.ToString();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined lobby.");
        Status.text = "Joined lobby.";
        PhotonNetwork.LoadLevel("Rooms");

    }

}
