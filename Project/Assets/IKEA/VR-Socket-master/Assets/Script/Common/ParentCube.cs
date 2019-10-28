using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCube : MonoBehaviour
{
    public GameObject Cube;


    public void Example(Transform newParent)
    {
        Cube.transform.SetParent(newParent);
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
