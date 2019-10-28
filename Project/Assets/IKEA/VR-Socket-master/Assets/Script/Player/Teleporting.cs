using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Valve.VR;
using Photon.Pun;

public class Teleporting : MonoBehaviourPunCallbacks
{
    public GameObject M_Pointer;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private FixedJoint m_Joint = null;

    public SteamVR_Action_Boolean m_TeleportAction;
    private bool m_HasPosition = false;
    private bool m_IsTeleporting = false;
    private float m_FadeTime = 0.5f;

    [SerializeField]
    private Transform CameraTesting;
    private Vector3 Camera;

    private void Awake()
    {
        if (photonView.IsMine)
        {
            m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
            m_Joint = GetComponent<FixedJoint>();
            M_Pointer.SetActive(false);

        }
    }
    private void Update()
    {
        if (photonView.IsMine)
        {
            m_HasPosition = UpdatePointer();
            M_Pointer.SetActive(m_HasPosition);

            // Teleport
            if (m_TeleportAction.GetLastStateUp(m_Pose.inputSource))
                TryTeleport();
        }


    }

    private void TryTeleport()
    {
        //Check for valid position, and if already teleporting
        if (!m_HasPosition || m_IsTeleporting)
            return;

        //transform
        CameraTesting = GameObject.FindWithTag("Player").transform;
        Debug.Log("Camera Rig Found!" + CameraTesting);

        //vector3
        Camera = GameObject.FindWithTag("Camera").transform.position;
        Debug.Log("Camera Found ! " + Camera);


        //Figure out translation
        Vector3 groundPosition = new Vector3(Camera.x, CameraTesting.position.y, Camera.z);
        Vector3 translateVector = M_Pointer.transform.position - groundPosition;

        //Move
        StartCoroutine(MoveRig(CameraTesting, translateVector));

        Debug.Log("Position = " + CameraTesting.transform.position);
        Debug.Log("Head Position: " + Camera);
        Debug.Log("Teleport");
    }

    private IEnumerator MoveRig(Transform CameraRig, Vector3 translation)
    {
        //Flag
        m_IsTeleporting = true;

        //Fade to black
        SteamVR_Fade.Start(Color.black, m_FadeTime, true);

        //Apply translation
        yield return new WaitForSeconds(m_FadeTime);
        CameraRig.position += translation;

        //Fade to clear
        SteamVR_Fade.Start(Color.clear, m_FadeTime, true);

        //De-flag
        m_IsTeleporting = false;


        yield return null;
    }


    private bool UpdatePointer()
    {
        //Ray from the controller
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        //If it`s a hit
        if (Physics.Raycast(ray, out hit))
        {
            M_Pointer.transform.position = hit.point;
            return true;
        }

        //If not a hit
        return false;
    }
    //END
}


