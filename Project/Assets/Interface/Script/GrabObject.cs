using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GrabObject : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Behaviour_Pose m_Pose = null;

    public SteamVR_Action_Boolean m_GrabAction = null;


    

    void Awake()

    {

        trackedObj = GetComponent<SteamVR_TrackedObject>();
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();

    }

    public GameObject collidingObject;//To keep track of what objects have rigidbodies

    public GameObject objectInHand;//To track the object you're holding

    void OnTriggerEnter(Collider other)//Activate function in trigger zone, checking rigidbodies and ignoring if no rigidbodies 

    {

        if (!other.GetComponent<Rigidbody>())

        {

            return;

        }

        collidingObject = other.gameObject;//If rigidbody, then assign object to collidingObject variable

    }

    void OnTriggerExit(Collider other)

    {

        collidingObject = null;

    }

    void Update()

    {

        //Down        
        if (m_GrabAction.GetStateDown(m_Pose.inputSource))
        {
            print(m_Pose.inputSource + "Trigger Down");
            ViveGrabObject();
        }

        //Up
        if (m_GrabAction.GetStateUp(m_Pose.inputSource))
        {
            print(m_Pose.inputSource + "Trigger Up");
            ReleaseObject();
        }
      
        
    }

    private void ViveGrabObject() // Picking up object and assigning objectInHand variable

    {

        objectInHand = collidingObject;

        objectInHand.transform.SetParent(this.transform);

        objectInHand.GetComponent<Rigidbody>().isKinematic = true;

    }

    // Releasing object and disabling kinematic functionality so other forces can affect object

    private void ReleaseObject()

    {

        objectInHand.GetComponent<Rigidbody>().isKinematic = false;

        objectInHand.transform.SetParent(null);

    }

}

