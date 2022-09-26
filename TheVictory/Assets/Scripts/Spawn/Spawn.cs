using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabTrabajador;
    public GameObject prefabGuerrero;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTrabajador()
    {
        Instantiate(prefabTrabajador, transform.position, transform.rotation);
    }
    
    public void SpawnGuerrero()
    {
        Instantiate(prefabGuerrero, transform.position, transform.rotation);
    }
    
}
