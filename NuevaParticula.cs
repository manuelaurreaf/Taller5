﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevaParticula : MonoBehaviour
{
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        particleSystem.Play(true);
        Debug.Log(message: "Entrando al trigger");
    }
}
