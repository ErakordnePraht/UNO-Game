using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class photonButtons : MonoBehaviour {

    public MenuLogic mLogic;

    public InputField createRoomInput, joinRoomInput;

    public void onClickCreateRoom()
    {
        if (createRoomInput.text.Length >= 1)
        {
            PhotonNetwork.CreateRoom(createRoomInput.text, new RoomOptions() { MaxPlayers = 2 }, null);
        }
    }

    public void onClickJoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomInput.text);
    }

    private void OnJoinedRoom()
    {
        mLogic.disableMenuUI();
        Debug.Log("We are connected to the room: " + createRoomInput.text);
    }
}
