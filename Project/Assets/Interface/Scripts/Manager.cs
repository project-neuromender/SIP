﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviourPunCallbacks
{
   /* #region Private Methods
    void LoadArena()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            Debug.LogError("PhotonNetwork : Trying to Load a level but we are not the master Client");
        }
        Debug.LogFormat("PhotonNetwork : Loading Level : {0}", PhotonNetwork.CurrentRoom.PlayerCount);
      
    }
    #endregion*/


   /*  #region Photon Callbacks
   /// <summary>
    /// Called when the local player left the room. We need to load the launcher scene.
    /// </summary>
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player other)
    {
        Debug.LogFormat("OnPlayerEnteredRoom() {0}", other.NickName); // not seen if you're the player connecting


        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient); // called before OnPlayerLeftRoom


            LoadArena();
        }
    }

    public override void OnPlayerLeftRoom(Player other)
    {
        Debug.LogFormat("OnPlayerLeftRoom() {0}", other.NickName); // seen when other disconnects


        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerLeftRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient); // called before OnPlayerLeftRoom


            LoadArena();
        }
    }
    #endregion*/


    #region Public Fields

    [Tooltip("The prefab to use for representing the player")]
    public  GameObject playerPrefab;
    public Transform spawnPoint;
   
    
    //public static Manager Instance;

    #endregion

    #region Public Methods

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.CurrentRoom == null)
        {
            Debug.Log("return to lobby");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Connectlobby");
            return;
        }
            //Debug.LogFormat("We are Instantiating LocalPlayer from {0}", SceneManagerHelper.ActiveSceneName);
            // we're in a room. spawn a character for the local player. it gets synced by using PhotonNetwork.Instantiate
           
            
        
        PhotonNetwork.Instantiate(this.playerPrefab.name, spawnPoint.position, Quaternion.identity, 0);
      

        //else
        //{

        //Debug.LogFormat("Ignoring scene load for {0}", SceneManagerHelper.ActiveSceneName);


    }

    public void LeaveRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    #endregion
}
