using System;
using Unity.VisualScripting;
using UnityEngine;

public class Unidad : MonoBehaviour
{
    void Start()
    {
        SeleccionUnidades.Instance.listaUnidades.Add(this.gameObject); 
    }

    void OnDestroy()
    {
        SeleccionUnidades.Instance.listaUnidades.Remove(this.gameObject);
    }
}
