using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public Image[] itemImages = new Image[numItemSlots];
    public ItemPrueba[] items = new ItemPrueba[numItemSlots];
	Color color;


    public const int numItemSlots = 5;

    public void AddItem(ItemPrueba itemToAdd)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
				itemImages[i].sprite = itemToAdd.GetSprite();
				color = itemImages [i].color;
				color.a = 1;
				itemImages [i].color = color;

                itemImages[i].enabled = true;
                return;
            }
        }
    }

    public void RemoveItem(ItemPrueba itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }
        }
    }

}
