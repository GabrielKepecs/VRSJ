using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLook : MonoBehaviour
{
    public AudioSource sound;
    public GameObject toEnable;
    public Rigidbody rdb;
    public Vector3 force;
    public bool Inspectable;
    public Transform Inspecting;
    private bool BeingInspect = false;

    //funcao que é chamada depois de um tempo olhando
    public void ButtonAction()
    {
        //toca o som escolhido
        if (sound)
        {
            sound.Play();
        }
        //habilita gameobjec selecionado
        if (toEnable)
        {
            toEnable.SetActive(true);
        }
        //adiciona uma força no objeto selecionado
        if (Inspectable)
        {

            Debug.Log("Analisado");
            transform.position = Inspecting.position;
            this.rdb.useGravity = false;
            BeingInspect = true;
            transform.gameObject.layer = 2;
            DragAndRotate script;
            script = GetComponent<DragAndRotate>();
            script.enabled = true;
            StartCoroutine(ExecuteAfterTime());
        }
        else
        {
            rdb.AddForce(force, ForceMode.Impulse);
        }
    }
    public void Largar()
    {
        BeingInspect = false;
        this.rdb.useGravity = true;
    }
    //se acontece uma colisao toca o so
    private void OnCollisionEnter(Collision collision)
    {
        if (sound)
        {
            sound.Play();
        }
    }
    private void Update()
    {
        if (BeingInspect)
        {
            transform.position = Inspecting.position;
        }
    }

    IEnumerator ExecuteAfterTime()
    {

        yield return new WaitForSeconds(15);
        BeingInspect = false;
        this.rdb.useGravity = true;
    }
}
