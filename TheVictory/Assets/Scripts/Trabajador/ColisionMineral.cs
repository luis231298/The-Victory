using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionMineral : MonoBehaviour
{ 
    public int cantidad = 10;
    public RecolecciónMineral recursoUP;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            recursoUP.SumaPuntos(cantidad);
            //other.GetComponent<RecolecciónMineral>().SumaPuntos(cantidad);
            //Debug.Log("adentro");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            recursoUP.SumaPuntos(cantidad);
            //other.GetComponent<RecolecciónMineral>().SumaPuntos(cantidad);
            //Debug.Log("adentro2");
        }
    }
    
    
    
    
    
}
