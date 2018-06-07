using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonConnect : MonoBehaviour
{

    public string versionName = "0.1";

    public GameObject ConnectToPhotonServerView, GameView, DisconnectedView;

    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(versionName);

        Debug.Log("Connecting to photon...");
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);

        Debug.Log("We are connected to master");
    }

    private void OnJoinedLobby()
    {
        ConnectToPhotonServerView.SetActive(true);

        Debug.Log("On Joined Lobby");
    }

    private void OnDisconnectedFromPhoton()
    {
        if (ConnectToPhotonServerView.activeSelf)
        {
            ConnectToPhotonServerView.SetActive(false);
        }
        if (GameView.activeSelf)
        {
            GameView.SetActive(false);
        }

        DisconnectedView.SetActive(true);

        Debug.Log("Dis from photon services");
    }

}
