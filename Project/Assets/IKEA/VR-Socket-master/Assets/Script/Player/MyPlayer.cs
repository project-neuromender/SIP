using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviourPunCallbacks, IPunObservable
{
    public Camera cam;
    // liat of scripts that should only be active for the local player( PlayerController)
    public MonoBehaviour[] localScripts;
    // list of GameObjects that should only be active for the local player (Camera,AudioListener)
    public GameObject[] localObjects;
    //values that will be synced over network
    Vector3 latestPos;
    Quaternion latestRot;
    private PhotonView PV;

   // public Text PlayerName;

    private string name;

    //private PlayerInputField PlayerInputField;
    //private Launcher launcher;

    #region MonoBehaviour CallBacks

    public void Start()
    {
        name = PhotonNetwork.NickName;
        Debug.Log("Player Name MyPlayer : " + name);

        GameObject.Find("Button").GetComponentInChildren<Text>().text = name;
    }

    // Start is called before the first frame update
    void Awake()
    {
        PV = GetComponent<PhotonView>();

        if (photonView.IsMine)
        {
            photonView.RPC("Moveable", RpcTarget.AllBuffered);
            photonView.RPC("Hand", RpcTarget.AllBuffered);
            photonView.RPC("Socket", RpcTarget.AllBuffered);
            photonView.RPC("Interactable", RpcTarget.AllBuffered);
            photonView.RPC("Slot", RpcTarget.AllBuffered);
            photonView.RPC("Static", RpcTarget.AllBuffered);
            photonView.RPC("ParentChild", RpcTarget.AllBuffered);
            photonView.RPC("Rotation", RpcTarget.AllBuffered);
            
            // MyPlayer.LocalPlayerInstance = this.gameObject;
            //DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            //deactivate if it is not YOU.
            cam.enabled = false;
            //player is remote, deactivate the scripts and object that should only be enabled for the local player
            for (int i = 0; i < localScripts.Length; i++)
            {
                localScripts[i].enabled = false;
            }
            for (int i = 0; i < localObjects.Length; i++)
            {
                localObjects[i].SetActive(false);
            }
        }

    }
    #endregion

    #region IPunObservable implementation

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);

        }

        else if (stream.IsReading)
        {
            latestPos = (Vector3)stream.ReceiveNext();
            latestRot = (Quaternion)stream.ReceiveNext();
        }
    }

    void Update()
    {
        if (!photonView.IsMine)
        {
            //Update remote Player (smooth this, this looks good, at the cost of some accuracy
            transform.position = Vector3.Lerp(transform.position, latestPos, Time.deltaTime * 5);
            transform.rotation = Quaternion.Lerp(transform.rotation, latestRot, Time.deltaTime * 5);

        }

    }
    #endregion
    
}
