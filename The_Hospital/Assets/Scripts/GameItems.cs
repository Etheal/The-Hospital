using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameItems : MonoBehaviour {

    [SerializeField] GameObject activarDescripcion;
    public Text texto;
    GameObject objetivoTrigger;
    ItemPrueba addObject;
    MeshRenderer mesh;

    void OnTriggerEnter(Collider colliderSarah)
    {

        objetivoTrigger = GameObject.Find("Button").GetComponent<Click>().GetObjetivoTrigger();


        if (gameObject == objetivoTrigger)
        {

            if (colliderSarah.CompareTag("Player"))
            {

                if (texto != null)
                {
                    texto.text = GetComponent<Objetos>().GetDescripcion();
                }

                activarDescripcion.SetActive(true);
                if (gameObject.tag == "Objeto")
                {
                    StartCoroutine(_CerrarDocumento());
                }
                if (gameObject.GetComponent<CursorType>().GetCursorType() == CursorType.Type.coger)
                {
                    addObject = objetivoTrigger.GetComponent<ItemPrueba>();
                    GameObject.Find("Inventario").GetComponent<Inventory>().AddItem(addObject);
                    gameObject.GetComponent<MeshRenderer>().enabled = false;
                    gameObject.GetComponent<Collider>().enabled = false;


                }
            }
        }
    }

    void OnTriggerExit(Collider colliderSarah)
    {
        if (colliderSarah.CompareTag("Player"))
        {
            activarDescripcion.SetActive(false);
        }
    }

    public void CerrarDocumento()
    {
        activarDescripcion.SetActive(false);
    }

    IEnumerator _CerrarDocumento()
    {
        yield return new WaitForSeconds(5);
        activarDescripcion.SetActive(false);
        gameObject.SetActive(false);
    }
}
