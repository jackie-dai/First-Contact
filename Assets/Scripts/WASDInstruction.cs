using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDInstruction : MonoBehaviour
{
    public GameObject instruction;
    private float numKeyStrokes;
    // Start is called before the first frame update
    void Start()
    {
        numKeyStrokes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        senseMovement();
    }
    
    void senseMovement()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0){
            numKeyStrokes++;
        }
        if(numKeyStrokes >= 5)
        {
            instruction.SetActive(false);
            Debug.Log("WASD instruction off");
        }
    }
}
