using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject HUDPanel;
    public GameObject PausePanel;
    public GameObject Configpanel;
    public GameObject ActivoPanel;
    public GameObject DesactivoPanel;
    public GameObject FinalNVL;
    
    public ColeccionableData _coleccionableData; 
    public const string pathData = "Data/Coleccion";
    public const string fileName = "coleccion";
    //private string aux; 

    private void Start()
    {
        ShowHud();
        var dataFound = SaveManager.LoadData<ColeccionableData>(pathData, fileName);
        if (dataFound != null)
        {
            _coleccionableData = dataFound; 
            Debug.Log(_coleccionableData.status);
        }
    }

    private void ClearPanels()
    {
        HUDPanel.SetActive(false);
        PausePanel.SetActive(false);
        Configpanel.SetActive(false);
        ActivoPanel.SetActive(false);
        DesactivoPanel.SetActive(false);
        FinalNVL.SetActive(false);
    }

    public void ShowHud()
    {
        ClearPanels();
        HUDPanel.SetActive(true);
    }

    public void ShowPause()
    {
        ClearPanels();
        PausePanel.SetActive(true);
    }

    public void ShowConfig()
    {
        ClearPanels();
        Configpanel.SetActive(true);
    }

    public void Final()
    {
        ClearPanels();
        FinalNVL.SetActive(true);
    }

    public void showColeccion()
    {
        if (_coleccionableData.status == true)
        {
            ClearPanels();
            ActivoPanel.SetActive(true);
        }
        else
        {
            ClearPanels();
            DesactivoPanel.SetActive(true);
        }
    }
}
