using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[PunRPC]
public class Static : Interactable
{
   // public GameObject spawnPrefab = null;
    public GameObject cube1;
   // public GameObject cube2;
    //public GameObject cube3;


    public override void StartInteraction(Hand hand)
    {
        Socket handSocket = hand.GetSocket();
        CreateObject(handSocket);

    }


    private void CreateObject(Socket socket)
    {
        if (socket.GetStoredObject())
            return;

        //GameObject newObject = Instantiate(spawnPrefab, socket.transform.position, Quaternion.identity);
        GameObject newObject = cube1;
        //newObject = PhotonNetwork.Instantiate(this.spawnPrefab.name, socket.transform.position, Quaternion.identity);
        Moveable moveable = newObject.GetComponent<Moveable>();
       
       


        moveable.AttachNewSocket(socket);

    }
}


