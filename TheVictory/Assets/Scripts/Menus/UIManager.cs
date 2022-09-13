using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject HUDPanel;
    public GameObject PausePanel;

    private void Start()
    {
        ShowHud();
    }

    private void ClearPanels()
    {
        HUDPanel.SetActive(false);
        PausePanel.SetActive(false);
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
}
