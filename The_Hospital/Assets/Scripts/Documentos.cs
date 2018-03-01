using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Documentos : MonoBehaviour {

	[SerializeField] GameObject activarDescripcion;
    GameObject objetivoTrigger;
	ItemPrueba addDocument;
	MeshRenderer mesh;

    
    void OnTriggerEnter(Collider colliderSarah)
    {

        objetivoTrigger = GameObject.Find("Button").GetComponent<Click>().GetObjetivoTrigger();


        if (gameObject == objetivoTrigger)
        {

            if (colliderSarah.CompareTag("Player"))
            {
 
                activarDescripcion.SetActive(true);
				/*if (gameObject.tag == "Objeto") 
				{
					StartCoroutine (_CerrarDocumento ());
				}*/
                if (gameObject.GetComponent<CursorType>().GetCursorType() == CursorType.Type.coger)
                {
                    addDocument = objetivoTrigger.GetComponent<ItemPrueba>();
					GameObject.Find ("Inventario").GetComponent<InventarioDocumentos>().AddDocument(addDocument);
					gameObject.GetComponent<MeshRenderer> ().enabled = false;
                    gameObject.GetComponent<Collider>().enabled = false;


                }
            }
        }
    }

    void OnTriggerExit(Collider colliderSarah)
	{
		if (colliderSarah.CompareTag("Player"))
		{
            activarDescripcion.SetActive (false);
		}
	}

    public void AbrirDocumento()
    {
        activarDescripcion.SetActive(true);
    }

	public void CerrarDocumento()
	{
		activarDescripcion.SetActive(false);
	}
    /*
	IEnumerator _CerrarDocumento ()
	{
		yield return new WaitForSeconds(5);
		activarDescripcion.SetActive(false);
		gameObject.SetActive(false);
	}*/
}
	