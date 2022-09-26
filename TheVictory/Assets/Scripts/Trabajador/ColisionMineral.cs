using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColisionMineral : MonoBehaviour
{ 
    public int cantidad = 10;
    public RecolecciónMineral recursoUP;
    public int Duracion; 
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trabajador")
        {
            recursoUP.SumaPuntos(cantidad);
            //other.GetComponent<RecolecciónMineral>().SumaPuntos(cantidad);
            //Debug.Log("adentro");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Trabajador")
        {
            recursoUP.SumaPuntos(cantidad);
            restaVida();
            //other.GetComponent<RecolecciónMineral>().SumaPuntos(cantidad);
            //Debug.Log("adentro2");
        }
    }

    private void restaVida()
    {
        Duracion -= cantidad;
        if (Duracion <= 0)
        {
            Destroy(gameObject);
        } 
    }
}
