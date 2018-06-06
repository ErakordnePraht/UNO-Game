using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour
{

	// Use this for initialization
	void Start ()
    {
        if (!isLocalPlayer)
        {
            //PlayerObject belongs to another player.
            return;
        }

        CmdSpawnMyUnit();
	}

    public GameObject PlayerPrefab;

	// Update is called once per frame
	void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }
	}

    GameObject myPlayerUnit;

    [Command]
    public void CmdSpawnMyUnit()
    {
        GameObject go = Instantiate(PlayerPrefab);

        myPlayerUnit = go;

        NetworkServer.Spawn(go);
    }
}
