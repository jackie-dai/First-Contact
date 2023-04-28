using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;

public class Flyer : MonoBehaviour
{
    BoxCollider2D area;
    bool inRange;
    bool needExamineMessage;
    bool currentlyExamining;
    public GameObject ExamineMessage;
    public GameObject FlyerDisplay;
    public GameObject MapMessage;
    public GameObject Cosmos;
    public GameObject WalkMessage;

    float count;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider2D>();
        inRange = false;
        needExamineMessage = true;
        currentlyExamining= false;
        ExamineMessage.SetActive(false);
        FlyerDisplay.SetActive(false);
        MapMessage.SetActive(false);
        WalkMessage.SetActive(true);
        count = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.X))
        {
            EnlargeHover.unlockedDiner = true;
            if (!currentlyExamining)
            {
                examine();
            } else
            {
                exitExamine();
            }
        }

        if (walking())
        {
            count++;
        }
        if(count >= 3)
        {
            WalkMessage.SetActive(false);
        }
    }
 
    bool walking()
    {
        if(Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown("w"))
        {
            return true;
        }
        return false;
    }

    public void act()
    {
        if (needExamineMessage && !MapMessage.activeSelf)
        {
            MapMessage.SetActive(false);
            ExamineMessage.SetActive(true);
            needExamineMessage = false;
        }
        inRange = true;
        Debug.Log("wooo we are acting");
    }
    public void unact()
    {
        inRange= false;
        //bad coding 
        needExamineMessage = true;
        ExamineMessage.SetActive(false);
        Debug.Log("we have left!");
        FlyerDisplay.SetActive(false);
    }
    void examine()
    {
        Debug.Log("inside examine");
        //makes it so we can't move
        Cosmos.GetComponent<PlayerController>().stopMovement();
        //allows us to see stuff
        FlyerDisplay.SetActive(true);
        
        ExamineMessage.SetActive(false);
        //tells us our next 'x' press will exit examine
        currentlyExamining = true;
        
    }
    void exitExamine()
    {
        Debug.Log("exit examine");
        Cosmos.GetComponent<PlayerController>().restartMovement();
        MapMessage.SetActive(true);
        FlyerDisplay.SetActive(false);
        currentlyExamining = false;
    }
}
