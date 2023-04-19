using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryUIController : MonoBehaviour
{
    public static InventoryUIController IUIC;
    private GameObject currentInfo;
    private List<GameObject> Items;

    #region Editor Variables
    [SerializeField]
    [Tooltip("the place to hold info")]
    private GameObject Info;

    [SerializeField]
    [Tooltip("the place to hold inventory object")]
    private GameObject Content;
    #endregion


    // Start is called before the first frame update
    void Awake()
    {
        IUIC = this;
        currentInfo = null;
        Items = InventoryManager.IM.getItems();
        foreach (GameObject item in Items)
        {
            AddItem(item);
        }
    }

    // Update is called once per frame
    
    public void ShowInfo(GameObject info)
    {
        if (currentInfo == null) 
        {
            currentInfo = Instantiate(info, Info.transform);
        } else 
        {
            Destroy(currentInfo.gameObject);
            currentInfo = Instantiate(info, Info.transform);
        }
    }

    public void exitScene()
    {
        SceneManager.UnloadScene("Inventory");
        PlayerController.playerController.gameObject.SetActive(true);
        PlayerController.exitMenu = true;
    }

    public void AddItem(GameObject item)
    {
        Instantiate(item, Content.transform);
    }
}
