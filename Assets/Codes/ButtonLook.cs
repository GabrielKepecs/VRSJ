using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLook : MonoBehaviour
{
    public GameObject Door;
    Door Door_script;

    //funcao que é chamada depois de um tempo olhando
    public void ButtonAction()
    {
        Door_script = Door.GetComponent<Door>();
        Door_script.Abre();
        Debug.Log("Interagiu");
    }
}
