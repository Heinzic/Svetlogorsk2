using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject nextPanel;
    public void OpenPanel()
    {
        if (Panel.active)
        {
            Panel.SetActive(false);
            nextPanel.SetActive(true);
            if (Time.timeScale != 0f)
                Time.timeScale = 0f;
            else Time.timeScale = 1f;
        }
    }
}
