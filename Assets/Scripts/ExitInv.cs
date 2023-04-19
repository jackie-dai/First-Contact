using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitInv : MonoBehaviour
{
    public void exitScene() 
    {
        InventoryUIController.IUIC.exitScene();
    }
}
