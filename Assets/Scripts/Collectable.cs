using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private bool onPlayer;
    #region Editor Variables
    [SerializeField]
    [Tooltip("inv item that can be added to inventory")]
    private GameObject InvItem;
    private bool added;
    #endregion

    private void AddToInv()
    {
        InventoryManager.IM.AddItem(InvItem);
        added = true;

    }

    void Awake() 
    {
        added = false;
    }

    void Update() 
    {
        if (onPlayer && Input.GetKeyDown("e"))
        {
            AddToInv();
        }

        if (added) 
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject other = collider.gameObject;
        if (other.CompareTag("Player"))
        {
            onPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        GameObject other = collider.gameObject;
        if (other.CompareTag("Player"))
        {
            onPlayer = false;
        }
    }
}
