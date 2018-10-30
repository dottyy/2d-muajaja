using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisico : MonoBehaviour {

    public float forceValue;
    private Rigidbody rigibody;
    private AudioSource sonido;

	// Use this for initialization
	void Start ()
    {
        rigibody = GetComponent<Rigidbody>();
        sonido = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        rigibody.AddForce(new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"))*2);
        if (Input.GetButtonDown("Jump") /*&&Mathf.Abs(rigibody.velocity.y)<0.01f*/) 
        {
             rigibody.AddForce(Vector3.up * 4, ForceMode.Impulse);
            sonido.Play();
        }
	}
}
