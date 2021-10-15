using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public float speed = 10;
    private CharacterController rig;
	// Use this for initialization
	void Start () {
        rig = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movements = new Vector3(hAxis, vAxis) * speed * Time.deltaTime; //MOves t
        rig.Move(transform.position+ movements);
	}
}
