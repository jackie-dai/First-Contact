using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void OnMouseDown()
    {
        Debug.Log("hovering");
        if (gameObject.CompareTag("Inventory"))
        {
            Debug.Log("Clicked on Inventory");
            this.GetComponentInParent<OverheadUI>().playerTransform.SetActive(false);
            SceneManager.LoadScene("Inventory", LoadSceneMode.Additive);
        }
        if (gameObject.CompareTag("Disguise"))
        {
            Debug.Log("Clicked on Disguise");
            this.GetComponentInParent<OverheadUI>().playerTransform.SetActive(false);
            SceneManager.LoadScene("Disguise", LoadSceneMode.Additive);
        }
        if (gameObject.CompareTag("Quit"))
        {
            Debug.Log("Clicked to Quit");
            this.GetComponentInParent<OverheadUI>().overheadUI.SetActive(false);
        }
        Debug.Log("pressed");
    }
}
