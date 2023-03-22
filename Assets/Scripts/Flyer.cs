using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyer : MonoBehaviour
{
    BoxCollider2D area;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {

        Debug.Log("Near Flyer!");
    }
}
