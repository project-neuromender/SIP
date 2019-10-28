using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[PunRPC]
public class Socket : MonoBehaviourPunCallbacks
{
    private Moveable storedObject = null;
    private FixedJoint joint = null;

    private void Awake()
    {
        if (photonView.IsMine)
        {
            joint = GetComponent<FixedJoint>();
        }
        
    }

    public void Attach(Moveable newObject)
    {
        if (storedObject)
            return;

        storedObject = newObject;

        storedObject.transform.position = transform.position;
        storedObject.transform.rotation = Quaternion.identity;

        Rigidbody targetBody = storedObject.gameObject.GetComponent<Rigidbody>();
        joint.connectedBody = targetBody;
    }

    public void Detach()
    {
        if (!storedObject)
            return;

        joint.connectedBody = null;
        storedObject = null;
    }

    public Moveable GetStoredObject()
    {
        return storedObject;
    }
}
