using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("the disguise to change to")]
    private GameObject Disguise;

    [SerializeField]
    [Tooltip("the corresponding prefab")]
    private GameObject playerPrefab;

    [SerializeField]
    [Tooltip("the disguiseCode unique to each disguise")]
    private int disguiseCode;
    #endregion

    public void ChangeDisguise(GameObject Disguise) 
    {
        DisguiseUIController.DUIC.ChangeDisguise(Disguise);
        DisguiseUIController.DUIC.setDisguiseCode(disguiseCode);
        Vector3 playerPosition = PlayerController.playerController.gameObject.transform.position;
        Destroy(PlayerController.playerController.gameObject);
        Instantiate(playerPrefab, playerPosition, Quaternion.identity);
    }
}
