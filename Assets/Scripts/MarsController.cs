using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsController : PlanetSketch
{
    // Use this for initialization
    void Start()
    {
        radius = 40.0f;
        speed = 0.08f;
        header = "Mars";
        info = "Mass: 0.642 * 10^24 kg\nDiameter: 6792 km\nGravity: 3.7 m/s^2\nDistance from Sun: 228.0 * 10^6 km";
        targetTag = 5;
    }
}
