using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusController : PlanetSketch
{
    // Use this for initialization
    void Start()
    {
        radius = 50.0f;
        speed = 0.1176f;
        header = "Venus";
        info = "Mass: 4.87 * 10^24 kg\nDiameter: 12104 km\nGravity: 8.9 m/s^2\nDistance from Sun: 108.2 * 10^6 km";
        targetTag = 2;
    }
}
