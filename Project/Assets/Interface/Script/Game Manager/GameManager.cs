using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Pun.Demo.PunBasics;

public class GameManager : MonoBehaviour
{
    private readonly object ballSpawnTransform;
    private GameObject player1;
    private GameObject ball;
    private GameObject player2;
    private object player1SpawnPosition;
    private object player2SpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (!PhotonNetwork.IsConnected) // 1
        {
            SceneManager.LoadScene("MainScene");
            return;
        }

        /*if (PlayerManager.LocalPlayerInstance == null)
        {
            if (PhotonNetwork.IsMasterClient) // 2
            {
                Debug.Log("Instantiating Player 1");
                // 3
                player1 = PhotonNetwork.Instantiate("SlotCar_A")
                    //player1SpawnPosition.transform.position,
                   // player1SpawnPosition.transform.rotation, 0);
                // 4
                ball = PhotonNetwork.Instantiate("SlotCar_C")
                   // ballSpawnTransform.transform.position,
                   // ballSpawnTransform.transform.rotation, 0);
                ball.name = "Ball";
            }
            else // 5
            {
                player2 = PhotonNetwork.Instantiate("SlotCar_A",
                   // player2SpawnPosition.transform.position,
                   // player2SpawnPosition.transform.rotation, 0);
            }
        }
    }*/

        // Update is called once per frame
        void Update()
        {

        }

    }
}
