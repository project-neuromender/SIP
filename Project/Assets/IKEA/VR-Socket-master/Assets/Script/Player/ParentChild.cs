using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


[PunRPC]
public class ParentChild : MonoBehaviour
{
    public GameObject parent;
    public GameObject slot;

    // Start is called before the first frame update
    void Start()
    {
        slot.transform.parent = parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
