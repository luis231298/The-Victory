using System;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform _transform;
    
    [SerializeField] float velocidad;

    [SerializeField] private float velRot;

    public Vector3 cambioZoom;// zoom amount 
    public Vector3 zoomAct; //new zoom

    private void Start()
    {
        zoomAct = _transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de la camara
        Vector3 dirección = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.D))//A
        {
            dirección.z += 1.0f; 
        } else if (Input.GetKey(KeyCode.A))//D
        {
            dirección.z -= 1.0f;
        } else if (Input.GetKey(KeyCode.W))//S
        {
            dirección.x -= 1.0f;
        } else if (Input.GetKey(KeyCode.S))//W
        {
            dirección.x += 1.0f;
        }

        transform.position += dirección * (velocidad * Time.deltaTime);
        
        // rotacion de la camara 
        float posrot = 0f;
        if (Input.GetKey(KeyCode.Q))
        {
            posrot += 1.0f;
        } else if (Input.GetKey(KeyCode.E))
        {
            posrot -= 1.0f;
        }

        transform.eulerAngles += new Vector3(0, posrot * velRot * Time.deltaTime,0);

        if (Input.GetKey(KeyCode.R))
        {
            zoomAct += cambioZoom;
        }
        if (Input.GetKey(KeyCode.F))
        {
            zoomAct -= cambioZoom;
        }

        if (zoomAct.y < 0)
        {
            zoomAct.y = 0;
        }
        
        
        if (Input.mouseScrollDelta.y != 0)
        {
            zoomAct += Input.mouseScrollDelta.y * cambioZoom;
        }


        if (zoomAct.z < 0)
        {
            zoomAct.z = 0;
        }

        _transform.localPosition = Vector3.Lerp(_transform.localPosition, zoomAct, Time.deltaTime /* velocidad*/);
        
        
    }
}
