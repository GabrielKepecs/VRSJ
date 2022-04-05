using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDyn : MonoBehaviour
{

    public string texto;
    public int quant;
    private void Start()
    {
        quant = 0;
        GetComponent<Text>().text = " " + texto + " " + quant;
    }

    // Update is called once per frame
    public void Quantidade()
    {

        quant = quant + 1;
       GetComponent<Text>().text = " " + texto +" " + quant ;
       

    }
}
