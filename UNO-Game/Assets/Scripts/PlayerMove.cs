using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : Photon.MonoBehaviour {

    public bool devTesting = false;
    public new PhotonView photonView;

	void Update () {
        if (!devTesting)
        {
            if (photonView.isMine)
            {
                CheckInput();
            } 
        }
	}

    private void CheckInput()
    {
        var move = new Draggable();
    }

    private void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(transform.position);
        }
    }
}
