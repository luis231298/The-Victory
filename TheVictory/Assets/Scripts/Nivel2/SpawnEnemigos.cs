using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public bool invensible;
    public  float tiempo;
    public GameObject prefabEnemigos;

    public int Recursos = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Recursos >= 0)
        {
            SpawnTrabajador();    
            restaRecurso();
            StartCoroutine(Espera());
        }
    }
    
    public void SpawnTrabajador()
    {
        Instantiate(prefabEnemigos, transform.position, transform.rotation);
        StartCoroutine(Espera());
    }
    
    IEnumerator Espera()
    {
        invensible = true;
        yield return new WaitForSeconds(tiempo);
        invensible = false;
    }

    public void restaRecurso()
    {
        Recursos -= 25;
    }
    
}
