using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("initial items in inventory")]
    private List<GameObject> InitialItems;

    public static InventoryManager IM;
    private List<GameObject> Items;

    void Awake()
    {
        IM = this;
        Items = InitialItems;
    }

    public void AddItem(GameObject item)
    {
        Items.Add(item);
    }

    public List<GameObject> getItems()
    {
        return Items;
    }
}
