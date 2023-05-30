using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterController : PlanetSketch
{
    // Use this for initialization
    void Start()
    {
        radius = 90.0f;
        speed = 0.06f;
        header = "Jupiter";
        info = "Mass: 1898 * 10^24 kg\nDiameter: 142984 km\nGravity: 23.1 m/s^2\nDistance from Sun: 778.5 * 10^6 km";
        targetTag = 6;
    }
}
