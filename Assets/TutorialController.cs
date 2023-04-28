using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public GameObject Tab;
    public GameObject Examine;
    public GameObject Enter;
    public GameObject I;
    public GameObject Exit;

    float count;
    // Start is called before the first frame update
    void Start()
    {
        Tab.SetActive(true);
        Examine.SetActive(false);
        Enter.SetActive(false);
        I.SetActive(false);
        Exit.SetActive(false);

        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count >= 3)
        {
            Tab.SetActive(false);
        }
        walking();
    }

    void walking()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
        {
            count++;
        }
    }
    public void examineMessage()
    {
        Examine.SetActive(true);
        Exit.SetActive(false);
        Enter.SetActive(false);
    }

    public void pickedUpMoney()
    {
        Examine.SetActive(false);
        I.SetActive(true);
    }

    public void enterMessage()
    {
        Enter.SetActive(true);
        I.SetActive(false);
        Examine.SetActive(false);
    }

    public void exitMessage()
    {
        Exit.SetActive(true);
        Debug.Log("set Exit active, set Enter inactive");
        Enter.SetActive(false);
    }
}
