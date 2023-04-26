using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverheadUI : MonoBehaviour
{
    //SpriteRenderer sp;
    public GameObject playerTransform;
    public Transform ourTransform;
    public float yOffset;

    public GameObject overheadUI;

    Vector3 playerPos;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //sp = GetComponent<SpriteRenderer>();
        //sp.enabled = false;

        playerPos = playerTransform.transform.position;
        overheadUI.SetActive(false);

        offset = new Vector3(0, yOffset,0);
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = playerTransform.transform.position;
        ourTransform.position = playerPos + offset;
        //Debug.Log("working in update" + playerPos.x + " " + playerPos.y);
    }

    public void appear()
    {
        //sp.enabled = true;
        overheadUI.SetActive(true);
        Debug.Log("inside appear()");
    }

    public void hide()
    {
        //sp.enabled = false;
        overheadUI.SetActive(false);
    }
}
