﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  hint2trigger1: MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.Play("boardletters");
        }
    }
}