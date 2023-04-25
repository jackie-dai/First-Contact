using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if(inside && Input.GetKeyDown(KeyCode.E))
        {
            PickedUp();
        }   
    }

    public void Enter()
    {
        E.SetActive (true);
        inside = true;    
    }

    public void Unenter()
    {
        inside = false;
    }
    public void PickedUp() 
    {
        E.SetActive (false);
        I.SetActive (true);
    }
}
