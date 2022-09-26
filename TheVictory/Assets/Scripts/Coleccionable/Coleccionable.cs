using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Coleccionable : MonoBehaviour
{
    public ColeccionableData _coleccionableData; 
    public const string pathData = "Data/Coleccion";
    public const string fileName = "coleccion";

    public void Start()
    {
        var dataFound = SaveManager.LoadData<ColeccionableData>(pathData, fileName);
        if (dataFound != null)
        {
            _coleccionableData = dataFound; 
            //Debug.Log(_coleccionableData.status);
        }
        else
        {
            _coleccionableData = new ColeccionableData();
            data();
        }

        _coleccionableData.status = false;
        data();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Trabajador" || other.tag == "Luchador")
        {
            //Debug.Log("Coleccionable");
            _coleccionableData.status = true;
            Destroy(gameObject);
            data();
            //SaveManager.SaveData("Coleccionable:" + colector.ToString(), pathData, fileName);
        }    
    }

    private void data()
    {
        SaveManager.SaveData(_coleccionableData, pathData, fileName);
    }
    
}
