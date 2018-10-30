using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverSpehereFlechas : MonoBehaviour {

    public float velocidad=30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal")* velocidad * Time.deltaTime,0, Input.GetAxis("Vertical") * velocidad * Time.deltaTime);
	}
}
