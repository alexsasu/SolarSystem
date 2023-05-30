using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneController : PlanetSketch
{
    // Use this for initialization
    void Start()
    {
        radius = 265.0f;
        speed = 0.03f;
        header = "Neptune";
        info = "Mass: 102 * 10^24 kg\nDiameter: 49528 km\nGravity: 11.0 m/s^2\nDistance from Sun: 4515 * 10^6 km";
        targetTag = 9;
    }
}
