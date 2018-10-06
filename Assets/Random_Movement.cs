using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Random_Movement : MonoBehaviour {
    public Transform vrCamera;
    public float speed;
    private CharacterController cc;
    private bool moveforward;

    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
    }

	// Update is called once per frame
	void Update () {
        Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
        cc.SimpleMove(forward * speed);


    }

    private int turnValue()
    {
        Random random = new Random();
        int turn_direction = 0; 
        return 0;
    }
      
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Substring(0, 4) == "Cube")
        {
            
        }
    }
}
