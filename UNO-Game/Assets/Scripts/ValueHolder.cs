using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class ValueHolder : NetworkBehaviour {
    [SyncVar] public GameObject TableCardSync;
    public static GameObject TableCard;

    private void Update()
    {
        TableCardSync = TableCard;
    }
}
