using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusController : PlanetSketch
{
    // Use this for initialization
    void Start()
    {
        radius = 70.0f;
        speed = 0.04f;
        header = "Uranus";
        info = "Mass: 86.8 * 10^24 kg\nDiameter: 51118 km\nGravity: 8.7 m/s^2\nDistance from Sun: 2867.0 * 10^6 km";
        targetTag = 8;
    }
}
