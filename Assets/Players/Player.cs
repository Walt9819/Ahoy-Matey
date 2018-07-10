using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    public Vector3 inputValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(inputValue);
	}
}
