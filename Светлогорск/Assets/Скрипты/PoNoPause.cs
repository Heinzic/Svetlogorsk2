using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoNoPause : MonoBehaviour
{
    public GameObject Panel;
    public GameObject nextPanel;
    public void OpenPanel()
    {
        if (Panel.active)
        {
            Panel.SetActive(false);
            nextPanel.SetActive(true);
        }
    }
}
