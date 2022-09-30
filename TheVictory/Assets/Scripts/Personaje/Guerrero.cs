using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : MonoBehaviour
{
    public double cantidad = 2.5;
    public double Duracion; 
    
    //Duración recursos
    public bool invensible;
    public  float tiempo;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemigo" || other.tag == "Player" )
        {
            animator.SetTrigger("Caminar");
            restaVida();
        }
    }
    
    private void restaVida()
    {
        if (!invensible)
        {
            Duracion -= cantidad;
            StartCoroutine(Espera());
            //Debug.Log(Duracion);
        }
        
        
        
        if (Duracion <= 0)
        {
            Destroy(gameObject);
        } 
    }
    
    IEnumerator Espera()
    {
        invensible = true;
        yield return new WaitForSeconds(tiempo);
        invensible = false;
    }
    
}
