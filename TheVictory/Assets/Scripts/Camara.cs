using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] float velocidad;

    [SerializeField] private float velRot;
    // Update is called once per frame
    void Update()
    {
        //movimiento de la camara
        Vector3 dirección = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            dirección.z += 1.0f; 
        } else if (Input.GetKey(KeyCode.S))
        {
            dirección.z -= 1.0f;
        } else if (Input.GetKey(KeyCode.A))
        {
            dirección.x -= 1.0f;
        } else if (Input.GetKey(KeyCode.D))
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

    }
}
