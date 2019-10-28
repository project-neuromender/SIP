using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    [System.Obsolete]
    IEnumerator Start()
    {
        WWW request = new WWW ("http://localhost/sqlconnect/WebTest.php");
        yield return request;
        Debug.Log(request.text);
    }
}
