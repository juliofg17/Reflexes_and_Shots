using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarBotones : MonoBehaviour {

    private int puntuacion_rojo, puntuacion_azul, objetivo_min, objetivo_max, objetivo;
    Vector3 nueva_pos_rojo, nueva_pos_azul;
    Quaternion rot;
    bool rojowin, azulwin;
    Pulsado scriptrojo, scriptazul;
    GameObject gamewin;

    // Use this for initialization
    void Start () {
        puntuacion_azul = puntuacion_rojo = 0;
        objetivo_min = 10;
        objetivo_max = 25;
        objetivo = Random.Range(objetivo_min, objetivo_max);
        rot.Set(0, 0, 0, 0);
        rojowin = azulwin = false;
        scriptrojo = GameObject.Find("botonrojo").GetComponent<Pulsado>();
        scriptazul = GameObject.Find("botonazul").GetComponent<Pulsado>();

	}
	
	
    public void Generar( bool rojo )
    {
        scriptazul.NuevaPosicion();
        scriptrojo.NuevaPosicion();

        if (rojo)
        {
            puntuacion_rojo++;
            Debug.Log("Rojo sube 1 punto. Tiene " + puntuacion_rojo + "p y el objetivo es de " + objetivo + "p.");
        }
        else puntuacion_azul++;

        if (puntuacion_rojo == objetivo) rojowin = true;
        if (puntuacion_azul == objetivo) azulwin = true;

        if (rojowin)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("scenerojowins");
        }

        if (azulwin)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("sceneazulwins");
        }

    }
}
