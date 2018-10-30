using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mata : MonoBehaviour {

    public GameObject player;
    public AudioSource sonidoMata;
    public AudioSource principal;

    // Use this for initialization
    void Start () {
        sonidoMata = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter(Collision collision)
    {
    //    sonidoMata.Play();
    //    principal.Stop();
        StartCoroutine("Espera");
    }
    // Update is called once per frame
    void Update () {
		
	}
    IEnumerator Espera() {
        for (float f=0;f<=2f;f+=0.2f) {
            yield return new WaitForSeconds(0.1f);
        }
        SceneManager.LoadScene(0);
    }
}
