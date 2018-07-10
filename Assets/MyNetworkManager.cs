using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MyNetworkManager : NetworkManager {

    public Text connectionText;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost()
    {
        connectionText.text += Time.timeSinceLevelLoad + " Starting host\n";
        StartHost();
    }

    public override void OnStartHost()
    {
        connectionText.text += Time.timeSinceLevelLoad + " Host started\n";
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        connectionText.text += Time.timeSinceLevelLoad + " Client start requested\n";
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        //base.OnClientConnect(conn);
        connectionText.text += Time.timeSinceLevelLoad + " Client is connect to IP: " + conn.address + "\n";
        CancelInvoke();
    }

    public void PrintDots()
    {
        connectionText.text += ".\n";
    }
}
