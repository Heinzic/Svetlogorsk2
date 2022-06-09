using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAtStart : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

}
