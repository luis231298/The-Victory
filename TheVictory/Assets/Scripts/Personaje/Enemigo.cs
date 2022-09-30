using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public int cantidad = 10;
    public int Duracion; 
    
    //Duración recursos
    public bool invensible;
    public  float tiempo;

    public NavMeshAgent _meshAgent;
    public Animator animator;
    //public CapsuleCollider _capsuleCollider; 
    //public Transform objetivo;
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
        if (other.tag == "Guerrero" || other.tag == "Player")
        {
            animator.SetTrigger("Atacando");
            restaVida();
            _meshAgent.SetDestination(other.transform.position);
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
