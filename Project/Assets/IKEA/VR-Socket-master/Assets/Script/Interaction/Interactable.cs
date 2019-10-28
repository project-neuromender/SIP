using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[PunRPC]
public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public Hand m_ActiveHand = null;

    protected bool isAvailable = true;

    public virtual void StartInteraction(Hand hand)
    {
        print("Start");
    }

    public virtual void Interaction(Hand hand)
    {
        print("interaction");
    }

    public virtual void EndInteraction(Hand hand)
    {
        print("End");
    }

    public bool GetAvailability()
    {
        return isAvailable;
    }
}
