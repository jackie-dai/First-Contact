using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("parent of the background")]
    private GameObject parent;

    [SerializeField]
    [Tooltip("normal face, faceCode = 0")]
    private GameObject normalFace;

    [SerializeField]
    [Tooltip("surprised face, faceCode = 1")]
    private GameObject surprisedFace;

    [SerializeField]
    [Tooltip("thinking face, faceCode = 2")]
    private GameObject thinkingFace;

    [SerializeField]
    [Tooltip("happy face, faceCode = 3")]
    private GameObject happyFace;

    [SerializeField]
    [Tooltip("current scene name")]
    private string sceneName;

    #region 
    private GameObject currentFace;
    static int faceCode;
    static bool finished;
    static bool demoEnd;
    #endregion

    void Awake()
    {
        faceCode = 0;
        finished = false;
        currentFace = Instantiate(normalFace, parent.transform);
    }

    void Update()
    {
        if (faceCode == 0)
        {
            Destroy(currentFace.gameObject);
            currentFace = Instantiate(normalFace, parent.transform);
        }
        if (faceCode == 1)
        {
            Destroy(currentFace.gameObject);
            currentFace = Instantiate(surprisedFace, parent.transform);
        }
        if (faceCode == 2)
        {
            Destroy(currentFace.gameObject);
            currentFace = Instantiate(thinkingFace, parent.transform);
        }
        if (faceCode == 3)
        {
            Destroy(currentFace.gameObject);
            currentFace = Instantiate(happyFace, parent.transform);
        }
        if (finished)
        {
            SceneManager.UnloadScene(sceneName);
        }
        if (demoEnd)
        {
            SceneManager.LoadScene("End");
        }
    }

    #region Yarn Functions
    [YarnFunction("getFaceCode")]
    public static int GetFaceCode() 
    { 
        return faceCode; 
    }

    // Yarb Commands can be static or non-static
    [YarnCommand("setFaceCode")]
    public static void SetFaceCode(int newCode) 
    { 
        faceCode = newCode;
    }
    #endregion

    [YarnCommand("exitScene")]
    public static void exitScene() 
    { 
        finished = true;
    }

    [YarnCommand("finishedDemo")]
    public static void finishedDemo(bool finished) 
    { 
        demoEnd = finished;
    }
}
