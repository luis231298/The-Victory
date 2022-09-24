using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ArrastreClick : MonoBehaviour
{
    Camera miCamera;

    [SerializeField] private RectTransform recuadro;

    private Rect _seleccion;

    private Vector2 inicio;
    private Vector2 fin;
    
    // Start is called before the first frame update
    void Start()
    {
        miCamera = Camera.main;
        inicio = Vector2.zero;
        fin = Vector2.zero;
        visual();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            inicio = Input.mousePosition;
            _seleccion = new Rect();
        }

        if (Input.GetMouseButton(0))
        {
            fin = Input.mousePosition;
            visual();
            seleccion();
        }

        if (Input.GetMouseButtonUp(0))
        {
            seleccionUnidades();
            inicio = Vector2.zero;
            fin = Vector2.zero;
            visual();
        }
    }

    void visual()
    {
        Vector2 dibujoCajaInicio = inicio;
        Vector2 dibujoCajaFin = fin;
        
        Vector2 centro = (dibujoCajaInicio + dibujoCajaFin)/2;
        recuadro.position = centro;

        Vector2 tamaño = new Vector2(Mathf.Abs(inicio.x - fin.x), Mathf.Abs(inicio.y - fin.y));

        recuadro.sizeDelta = tamaño;
    }

    void seleccion()
    {
        if (Input.mousePosition.x < inicio.x)
        {
            _seleccion.xMin = Input.mousePosition.x;
            _seleccion.xMax = inicio.x;
        }
        else
        {
            _seleccion.xMin = inicio.x; 
            _seleccion.xMax = Input.mousePosition.x;
        }

        if (Input.mousePosition.y < inicio.y)
        {
            _seleccion.yMin = Input.mousePosition.y;
            _seleccion.yMax = inicio.y;
        }
        else
        {
            _seleccion.yMin = inicio.y;
            _seleccion.yMax = Input.mousePosition.y; 
        }
    }

    void seleccionUnidades()
    {
        foreach (var unidad in SeleccionUnidades.Instance.listaUnidades)
        {
            if (_seleccion.Contains(miCamera.WorldToScreenPoint(unidad.transform.position)))
            {
                SeleccionUnidades.Instance.SeleccionDibujo(unidad);
            }
        }
    }
}
