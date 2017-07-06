using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarjuego : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(wait());
        
    }
	
	// Update is called once per frame
	void Update () {

        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3.0f);
        Time.timeScale = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");

    }
}
