using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private Vector3 startingPosition;
    [SerializeField] private Vector3 movementVector;
    private float movementFactor;
    [SerializeField] private float period = 2f;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) //if (period == 0f)
        {
            return;
        }

        float cycles = Time.time / period; //continually growing over time

        const float tau = Mathf.PI * 2; // constant value of 6.283
        float rawSinWave = Mathf.Sin(cycles * tau); //going from -1 to 1

        movementFactor = (rawSinWave + 1f) / 2f; //recalculated to go from 0 to 1 so its cleaner

        //Debug.Log(rawSinWave);

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}