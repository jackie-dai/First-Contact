using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInfo : MonoBehaviour
{
    public void ShowInfo(GameObject info) 
    {
        InventoryUIController.IUIC.ShowInfo(info);
    }
}
