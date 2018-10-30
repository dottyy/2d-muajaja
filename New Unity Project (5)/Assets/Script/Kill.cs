using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour {
    public GameObject player;
    public AudioSource sonidoMata;
    public AudioSource principal;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        //sonidoMata.Play();
        //principal.Stop();
        StartCoroutine("Espere");
       
    }

    IEnumerator Espere()
    {
        for (float f = 0; f <= 2f; f += 0.2f)
        {
            yield return new WaitForSeconds(0.5f);
        }
        SceneManager.LoadScene(0);
    }
}
