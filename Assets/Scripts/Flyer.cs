using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;

public class Flyer : MonoBehaviour
{
    BoxCollider2D area;
    bool inRange;
    public GameObject ExamineMessage;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        inRange = false;
        ExamineMessage.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {

        Debug.Log("Near Flyer!");
    }
    public void act()
    {
        ExamineMessage.SetActive(true);
        Debug.Log("wooo we are acting");
    }
    public void unact()
    {
        ExamineMessage.SetActive(false);
        Debug.Log("we have left!");
    }
}
