using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[PunRPC]
public class Slot : Interactable
{
    private Socket socket = null;

    private void Awake()
    {
        socket = GetComponent<Socket>();
    }

    public override void StartInteraction(Hand hand)
    {

        Socket handSocket = hand.GetSocket();
        Moveable heldObject = handSocket.GetStoredObject();


        if (heldObject)
        {
            TryStore(heldObject);

            GameObject Cube = GameObject.FindGameObjectWithTag("Cube");
            gameObject.GetComponentInChildren<Renderer>().enabled = false;

        }
        else
        {
           TryRetrieve(handSocket);

           GameObject Cube = GameObject.FindGameObjectWithTag("Cube");
           gameObject.GetComponentInChildren<Renderer>().enabled = true;
 
        }
    }

    private void TryStore(Moveable newMoveable)
    {
        if (!socket.GetStoredObject())
            newMoveable.AttachNewSocket(socket);

            
    }

    private void TryRetrieve(Socket newSocket)
    {
        Moveable objectToRetrieve = socket.GetStoredObject();
        if (objectToRetrieve)
            objectToRetrieve.AttachNewSocket(newSocket);
    }
}
