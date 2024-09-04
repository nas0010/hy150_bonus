using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottrigger : MonoBehaviour
{
    private Animator anim;
    public AudioSource source;
    public AudioClip clip;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        timerIsRunning = true;
    }
    public float timeRemaining = 10;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            anim.Play("botanimation");
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
}