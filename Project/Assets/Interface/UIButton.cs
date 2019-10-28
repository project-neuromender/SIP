using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;


[PunRPC]
public class UIButton : MonoBehaviourPunCallbacks
{
    public SteamVR_LaserPointer laserPointer;

    private void Awake()
    {
        if (photonView.IsMine)
        {
            laserPointer.PointerIn += OnPointerIn;
            laserPointer.PointerOut += OnPointerOut;
            laserPointer.PointerClick += PointerClick;
        }

    }


    public void OnPointerIn(object sender, PointerEventArgs e)
    {

    }

    public void OnPointerOut(object sender, PointerEventArgs e)
    {


    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "LeaveButton")
        {
            Debug.Log("Button was clicked");
            OnLeftRoom();
        }
    }



    public override void OnLeftRoom()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel(4);
       // UnityEngine.SceneManagement.SceneManager.LoadScene("Rooms");
    }
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


