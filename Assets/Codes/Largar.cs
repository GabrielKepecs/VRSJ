using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Largar : MonoBehaviour
{
    public GameObject Inspected;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.gameObject.SendMessageUpwards("Largar");
        }
    }

    void Click()
    {
        transform.gameObject.SendMessageUpwards("Largar");
    }
}
