using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseAudio_Junk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Junkyard")
            BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
        
    }
}
