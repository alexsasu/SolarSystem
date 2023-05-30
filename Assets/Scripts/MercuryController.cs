using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercuryController : PlanetSketch
{
    // Use this for initialization
    void Start()
    {
        radius = 40.0f;
        speed = 0.16f;
        header = "Mercury";
        info = "Mass: 0.33 * 10^24 kg\nDiameter: 4879 km\nGravity: 3.7 m/s^2\nDistance from Sun: 57.9 * 10^6 km";
        targetTag = 1;
    }
}