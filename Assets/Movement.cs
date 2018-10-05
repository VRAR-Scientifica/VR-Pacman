using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Transform vrCamera;
    public float speed;
    public float toggleangle;
    private CharacterController cc;
    private bool moveforward;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if((vrCamera.transform.eulerAngles.x <= toggleangle && vrCamera.transform.eulerAngles.x >= 0f) || (vrCamera.transform.eulerAngles.x >= 360f-toggleangle && vrCamera.transform.eulerAngles.x <= 360f))
        {
            moveforward = true;
        }
        else
        {
            moveforward = false;
        }
        
        if(moveforward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
	}
}
