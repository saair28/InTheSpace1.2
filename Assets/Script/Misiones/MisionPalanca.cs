﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionPalanca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //FindObjectOfType<AudioManager>.pla
            FindObjectOfType<AudioManager>().Play("MisionPalanca");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Pause("MisionPalanca");

        }
    }
}

