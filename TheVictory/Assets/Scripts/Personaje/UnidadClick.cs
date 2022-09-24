using System;
using UnityEngine;

public class UnidadClick : MonoBehaviour
{
    private Camera miCamara;

    public LayerMask seleccionable;
    public LayerMask suelo;
    
    void Start()
    {
     miCamara = Camera.main;  
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = miCamara.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit,Mathf.Infinity, seleccionable))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    SeleccionUnidades.Instance.ShiftSeleccionClick(hit.collider.gameObject);
                }
                else
                {
                    SeleccionUnidades.Instance.SeleccionClick(hit.collider.gameObject);
                }
            }
            else
            {
                if (!Input.GetKey(KeyCode.LeftShift))
                {
                    SeleccionUnidades.Instance.Deseleccion();
                }
            }
        }
    }
}
