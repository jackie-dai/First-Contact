using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTutorial : MonoBehaviour
{
    BoxCollider2D area;
    public GameObject E;
    public GameObject I;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void display()
    {
        E.SetActive(true);
        I.SetActive(false);
    }

    public void undisplay()
    {
        E.SetActive(false);
    }
}
