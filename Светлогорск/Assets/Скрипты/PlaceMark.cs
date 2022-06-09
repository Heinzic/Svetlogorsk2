using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMark : MonoBehaviour
{
    public GameObject Mark;
    // Start is called before the first frame update
    void Start()
    {
        Mark = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {

                //Destroy(Mark);
                var spawnPos = Camera.main.ScreenToViewportPoint(touch.position);
                Instantiate(Mark, spawnPos, Quaternion.identity);
            }
        }
    }
}
