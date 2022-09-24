using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecolecciónMineral : MonoBehaviour
{
    private int recurso = 0; 
    private TextMeshProUGUI textmesh;

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
        recurso += material;
        Debug.Log(recurso);
    }
    
    public void ActualizarRecursoMineral(int Mineral)
    {
        recurso = Mineral;
    }
}
