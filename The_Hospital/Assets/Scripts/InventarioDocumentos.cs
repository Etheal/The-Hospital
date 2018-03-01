using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioDocumentos : MonoBehaviour {

    public ItemPrueba[] documents = new ItemPrueba[numDocumentSlots];
    public Text [] texts = new Text [numDocumentSlots];



    public const int numDocumentSlots = 20;

    public void AddDocument(ItemPrueba documentToAdd)
    {
        for (int i = 0; i < documents.Length; i++)
        {
            if (documents[i] == null)
            {
                documents[i] = documentToAdd;
                texts[i].text = documentToAdd.GetString();
                return;
            }
        }
    }

    public void RemoveDocument(ItemPrueba documentToRemove)
    {
        for (int i = 0; i < documents.Length; i++)
        {
            if (documents[i] == documentToRemove)
            {
                documents[i] = null;
                texts[i].text = null;

                return;
            }
        }
    }

    public void AbrirEsteDocumento(int i)
    {
        documents[i].GetComponent<Documentos>().AbrirDocumento();
    }
}

