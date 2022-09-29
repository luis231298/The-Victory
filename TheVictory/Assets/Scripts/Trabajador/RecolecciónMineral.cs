using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecolecciónMineral : MonoBehaviour
{
    private int recurso = 0; 
    private TextMeshProUGUI textmesh;
    
    //Duración recursos
    public bool invensible;
    public  float tiempo;
    
    private void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textmesh.text = $"{recurso}";
    }

    public void SumaPuntos(int material)
    {
        if (!invensible)
        {
            recurso += material;
            StartCoroutine(Espera());
            //Debug.Log(Duracion);
        }
    }
    
    public void ActualizarRecursoMineral(int Mineral)
    {
        recurso = Mineral;
    }
    
    IEnumerator Espera()
    {
        invensible = true;
        yield return new WaitForSeconds(tiempo);
        invensible = false;
    }
    
}
