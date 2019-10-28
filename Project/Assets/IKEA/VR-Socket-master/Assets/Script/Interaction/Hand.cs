using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Photon.Pun;

[PunRPC]
public class Hand : MonoBehaviourPunCallbacks
{
    //private bool activity;
    public GameObject menu;
    public GameObject pointer;
    public GameObject controller;
    public GameObject controllerPointer;
  
    private Socket socket = null;
    private SteamVR_Behaviour_Pose pose = null;

    public SteamVR_Action_Boolean m_GrabAction = null;
    private FixedJoint m_Joint = null;

    private Interactable m_CurrentInteractable = null;
    public List<Interactable> contactInteractables = new List<Interactable>();

    private void Awake()
    {
        if (photonView.IsMine)
        {
            socket = GetComponent<Socket>();
            pose = GetComponent<SteamVR_Behaviour_Pose>();
            m_Joint = GetComponent<FixedJoint>();
            menu.SetActive(false);
            pointer.SetActive(false);
            
            controller.GetComponent<Teleporting>().enabled = false;

        }
    }

    public void Teleport()
    {
       
        controller.GetComponent<Teleporting>().enabled = true;
        controllerPointer.SetActive(true);

    }

    public void CantTeleport()
    {
        controller.GetComponent<Teleporting>().enabled = false;
        controllerPointer.SetActive(false);

    }

    public void PointerOut()
    {
        pointer.SetActive(false);
    }
    public void LeaveRoom()
    {
        pointer.SetActive(true);

    }

    public void MenuAppear()
    {
        menu.SetActive(true);
    }

    public void MenuDissappear()
    {
        menu.SetActive(false);
    }

   
    public void Pickup()
    {
        //Get nearest
        m_CurrentInteractable = GetNearestInteractable();

        //Null Check
        if (!m_CurrentInteractable)
            return;

        // Already held,check
        if (m_CurrentInteractable.m_ActiveHand)
            m_CurrentInteractable.m_ActiveHand.Drop();

        //Position
        m_CurrentInteractable.transform.position = transform.position;

        //Attach
        Rigidbody targetBody = m_CurrentInteractable.GetComponent<Rigidbody>();
        m_Joint.connectedBody = targetBody;

        //Set active hand
        m_CurrentInteractable.m_ActiveHand = this;

    }

    
    public void Drop()
    {
        //Null check
        if (!m_CurrentInteractable)
            return;

        //Apply velocity
        Rigidbody targetBody = m_CurrentInteractable.GetComponent<Rigidbody>();

        targetBody.velocity = pose.GetVelocity();
        targetBody.angularVelocity = pose.GetAngularVelocity();

        //Detach
        m_Joint.connectedBody = null;

        //clear
        m_CurrentInteractable.m_ActiveHand = null;
        m_CurrentInteractable = null;
    }

    private Interactable GetNearestInteractable()
    {
        Interactable nearest = null;
        float minDistance = float.MaxValue;
        float distance = 0.0f;

        foreach (Interactable interactable in contactInteractables)
        {
            distance = (interactable.transform.position - transform.position).sqrMagnitude;

            if (distance < minDistance)
            {
                minDistance = distance;
                nearest = interactable;
            }
        }

        return nearest;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (photonView.IsMine)
        {
            AddInteractable(other.gameObject);
        }
    }

    private void AddInteractable(GameObject newObject)
    {
        if (photonView.IsMine)
        {
            //layer "interactable"
            Interactable newInteractable = newObject.GetComponent<Interactable>();

            // add list
            contactInteractables.Add(newInteractable);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (photonView.IsMine)
        {
            //function interact dgn interactable script
            RemoveInteractable(other.gameObject);
        }
    }

    private void RemoveInteractable(GameObject newObject)
    {
        if (photonView.IsMine)
        {
            // remove cube in Hand
            Interactable exisitngInteractable = newObject.GetComponent<Interactable>();
            //remove from list contact interactable
            contactInteractables.Remove(exisitngInteractable);
        }
    }

    public void GrabObject()
    {
        Pickup();
    }

    public void DropObject()
    {
        Drop();
    }

    public void TryInteraction()
    {
        if (NearestInteraction())
            return;

        HeldInteraction();
    }

    private bool NearestInteraction()
    {
        Interactable nearestObject = Utility.GetNearestInteractable(transform.position, contactInteractables);

        if (nearestObject ) 
            nearestObject.StartInteraction(this);

        return nearestObject;
    }
    
    private void HeldInteraction()
    {
        Moveable heldObject = socket.GetStoredObject();

        if (heldObject) 
        heldObject.Interaction(this);
    }
    
    public void StopInteraction()
    {
          Moveable heldObject = socket.GetStoredObject();
        if (heldObject)
          heldObject.EndInteraction(this);
    }

    public Socket GetSocket()
    {
        return socket;
    }

    public SteamVR_Behaviour_Pose GetPose()
    {
        return pose;
    }

   
}
