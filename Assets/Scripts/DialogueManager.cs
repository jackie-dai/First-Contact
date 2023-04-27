using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("dialogue code")]
    private static int dialogueCode;

    public static DialogueManager DM;

    void Awake()
    {
        DM = this;
    }

    [YarnFunction("getDialogue")]
    public static int getDialogue() 
    {
        return dialogueCode;
    }

    public void setDialogueCode(int code)
    {
        dialogueCode = code;
    }
}
