using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;

public class MoneyTutorial : MonoBehaviour
{
    BoxCollider2D area;
    public GameObject E;
    public GameObject I;
    bool inside;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        E.SetActive(false);
        I.SetActive(false);
        inside = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("updating");
        if(inside && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("update work");
            PickedUp();
        }   
    }

    //have to exit area and press e. /maybe when picking 
    //files in inventory ui controller

    public void Enter()
    {
        Debug.Log("entered");
        E.SetActive (true);
        inside = true;    
    }

    public void Unenter()
    {
        E.SetActive(false);
    }
    public void PickedUp() 
    {
        Debug.Log("we know its been picked up");
        E.SetActive (false);
        I.SetActive (true);
    }
}
