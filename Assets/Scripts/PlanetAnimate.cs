using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * class to apply a bobbing and rotation animation to a planet object
 */

public class PlanetAnimate : MonoBehaviour
{
    public float bobSpeed = 1.0f;     // speed of vertical motion
    public float bobHeight = 0.01f;   // how far the motion travels
    public float rotationSpeed = 30.0f; // speed of the rotation on the Y-axis

    private Vector3 initialPosition;  // initial position of the planet, stored to calculate bobbing motion

    void Start()
    {
        // store the initial position of the planet
        initialPosition = transform.position;
    }

    void Update()
    {
        // calculate the new position for bobbing
        Vector3 newPosition = initialPosition + new Vector3(0.0f, Mathf.Sin(Time.time * bobSpeed) * bobHeight, 0.0f);

        // update the position of the planet
        transform.position = newPosition;

        // rotate the planet on the Y-axis
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }
}