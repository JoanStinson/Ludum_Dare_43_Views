﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {
    public GameObject blade;
    public float distanceBlade;
    public float distanceParticles;
    public GameObject particles;
    private Vector3 bladePos;
    private Vector3 posInitBlade;
    private Vector3 particlesPos;
    private Vector3 posInitParticles;

    // Use this for initialization
    void Start () {
    }

    void  Update()
    {
        if (Input.GetMouseButton(0))
        {
            posInitBlade = Input.mousePosition;
            posInitBlade.z = distanceBlade;
            bladePos = Camera.main.ScreenToWorldPoint(posInitBlade);

            posInitParticles = Input.mousePosition;
            posInitParticles.z = distanceParticles;
            particlesPos = Camera.main.ScreenToWorldPoint(posInitParticles);
            

            if (!blade.gameObject.activeSelf) {
                blade.SetActive(true);
                
            }
            else
            {
                blade.transform.position = bladePos;
                
            }

            if (!particles.gameObject.activeSelf && !GameManager.instance.isPause)
            {
                particles.SetActive(true);
            }

            else{
                particles.transform.position = particlesPos;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {

            blade.SetActive(false);
            particles.SetActive(false);
        }
    }
}
