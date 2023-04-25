using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DisguiseTutorial : MonoBehaviour
{
    float count;
    public GameObject tab;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        tab.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        counting();
        if(count > 5)
        {
            tab.SetActive(false);
        }
    }

    Boolean walking()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D))
        {
            return true;
        } else {
            return false;
        }
    }

    void counting()
    {
        if (walking()) 
        {
            count++;
        }
    }
}
