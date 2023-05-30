using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSketch : MonoBehaviour
{
    public float radius;
    public float speed;
    public string header;
    public string info;
    public int targetTag;

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
            ZoomTarget.target_tag = targetTag;
            TimeScale.header = header;
            TimeScale.info = info;
        }
    }
}
