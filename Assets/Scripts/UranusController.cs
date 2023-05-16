using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusController : MonoBehaviour
{
    public float radius = 70.0f;
    public float speed = 0.04f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = GetPosition(Time.time * speed);
    }

    private Vector3 GetPosition(float angle)
    {
        return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
    }

    void OnMouseDown()
    {
        bool zoom = ZoomTarget.zoom;
        if (zoom)
        {
            ZoomTarget.zoom = false;
            ZoomTarget.target_tag = 0;
            TimeScale.header = "Solar System";
            TimeScale.info = "Mercury\nVenus\nEarth\nMars\nJupiter\nSaturn\nUranus\nNeptune";
        }
        else
        {
            ZoomTarget.zoom = true;
            ZoomTarget.target_tag = 8;
            TimeScale.header = "Uranus";
            TimeScale.info = "Mass: 86.8 * 10^24 kg\nDiameter: 51118 km\nGravity: 8.7 m/s^2\nDistance from Sun: 2867.0 * 10^6 km";
        }
    }
}
