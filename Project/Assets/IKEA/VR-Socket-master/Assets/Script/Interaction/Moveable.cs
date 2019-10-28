using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Valve.VR;
using Photon.Pun;

[PunRPC]
public class Moveable : Interactable
{
    private Socket activeSocket = null;

    public override void StartInteraction(Hand hand)
    {
        AttachNewSocket(hand.GetSocket());
    }

    public override void Interaction(Hand hand)
    {
        //GetComponent<ColorToggle>().ToggleColor();
    }

    public override void EndInteraction(Hand hand)
    {
        ReleaseOldSocket();
        ApplyHandVelocity(hand);
    }

    public void AttachNewSocket(Socket newSocket)
    {
        if (newSocket.GetStoredObject())
            return;

        ReleaseOldSocket();
        activeSocket = newSocket;

        activeSocket.Attach(this);
        isAvailable = false;
    }

    public void ReleaseOldSocket()
    {
        if (!activeSocket)
            return;

        activeSocket.Detach();
        activeSocket = null;
        isAvailable = true;
    }

    private void ApplyHandVelocity(Hand hand)
    {
        SteamVR_Behaviour_Pose pose = hand.GetPose();
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = pose.GetVelocity();
        rigidbody.angularVelocity = pose.GetAngularVelocity();
    }
}
