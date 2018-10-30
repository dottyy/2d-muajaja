using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarEscene : MonoBehaviour {

	// Use this for initialization
 	public void PasaEscena () {
        SceneManager.LoadScene(1);		
	}

    public void Regresa()
    {
        SceneManager.LoadScene(0);
    }

    public void Guardar()
    {
        SceneManager.LoadScene(2);
    }
    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }
    public void Opciones()
    {
        SceneManager.LoadScene(4);
    }
    public void Cargar()
    {
        SceneManager.LoadScene(5);
    }
    public void guardando()
    {
        SceneManager.LoadScene(6);
    }

}
