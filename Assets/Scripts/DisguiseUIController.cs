using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class DisguiseUIController : MonoBehaviour
{
    public static DisguiseUIController DUIC;
    public GameObject startDisguise;
    #region Editor Variables
    [SerializeField]
    [Tooltip("the parent")]
    private GameObject parent;

    [SerializeField]
    [Tooltip("the defult disguise")]
    public GameObject defaultDisguise;
    #endregion

    #region Private Vairables 
    private GameObject currentDisguise;
    #endregion

    #region Yarn variables
    static int disguiseCode;
    #endregion

    // Start is called before the first frame update
    #region Unity Functions
    void Awake()
    {
        DUIC = this;
        startDisguise = PlayerController.playerController.UIPrefab;
        currentDisguise = Instantiate(startDisguise, parent.transform);
    }

    public void ChangeDisguise(GameObject Disguise)
    {
        Destroy(currentDisguise.gameObject);
        currentDisguise = Instantiate(Disguise, parent.transform);
    }

    public void exitScene()
    {
        SceneManager.UnloadScene("disguise");
        PlayerController.playerController.gameObject.SetActive(true);
        PlayerController.exitMenu = true;
    }
    #endregion

    #region Yarn Functions
    [YarnFunction("getDisguiseCode")]
    public static int getDisguiseCode() 
    {
        return disguiseCode;
    }

    public void setDisguiseCode(int code)
    {
        disguiseCode = code;
    }
    #endregion
}
