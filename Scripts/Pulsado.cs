using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsado : MonoBehaviour {

    // Use this for initialization

    
    Vector3 nueva_pos;
    Quaternion rot;
    bool pulsando;
    GenerarBotones gen;
    

    void Start () {
        gen = GameObject.Find("Pantalla").GetComponent<GenerarBotones>();

	}

    private void FixedUpdate()
    {
        
    }

   

    public void NuevaPosicion()
    {
        if (this.tag == "BotonRojo")
        {

            nueva_pos.Set(Random.Range(-2.5f, 2.5f), Random.Range(-4.5f, -0.3f), 0);
            this.transform.SetPositionAndRotation(nueva_pos, rot);
        }
        else
        {
            nueva_pos.Set(Random.Range(-2.5f, 2.5f), Random.Range(0.3f, 4.5f), 0);
            this.transform.SetPositionAndRotation(nueva_pos, rot);
        }

    }


    private void OnMouseOver()
    {
        if (this.tag == "BotonRojo") gen.Generar(true);
        else gen.Generar(false);
    }
}
