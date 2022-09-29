using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public Inicio _inicio;
    public GameObject[] enemigos;
    [SerializeField] private string escena;
    //public GameObject escFinal;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(enemigos);
        enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
    }

    // Update is called once per frame
    void Update()
    {
        enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
        if (enemigos.Length == 0)
        {
            SceneManager.LoadScene(escena);
        }
    }
}
