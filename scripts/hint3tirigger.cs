using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint3tirigger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }
    public float timeRemaining = 10;
    // Update is called once per frame
    void Update()
    {
            if (timerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    source.PlayOneShot(clip);
                    timeRemaining = 0;
                    timerIsRunning = false;
                }
        }
    }
}
