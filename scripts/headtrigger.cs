﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headtrigger : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("head");
        }
    }
}