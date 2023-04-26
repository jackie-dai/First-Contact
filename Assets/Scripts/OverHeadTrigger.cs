using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverHeadTrigger : MonoBehaviour
{
    BoxCollider2D area;
    // Start is called before the first frame update
    void Start()
    {
        area= GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Debug.Log("hovering");
        if (gameObject.CompareTag("Inventory"))
        {
            Debug.Log("hovering over Inventory");
        }
        if (gameObject.CompareTag("Disguise"))
        {
            Debug.Log("hovering over Disguise");
        }
        if (gameObject.CompareTag("Quit"))
        {
            Debug.Log("hovering over Quit");
        }

    }

    private void OnMouseDown()
    {
        Debug.Log("hovering");
        if (gameObject.CompareTag("Inventory"))
        {
            Debug.Log("Clicked on Inventory");
        }
        if (gameObject.CompareTag("Disguise"))
        {
            Debug.Log("Clicked on Disguise");
        }
        if (gameObject.CompareTag("Quit"))
        {
            Debug.Log("Clicked to Quit");
        }
        Debug.Log("pressed");
    }
}
