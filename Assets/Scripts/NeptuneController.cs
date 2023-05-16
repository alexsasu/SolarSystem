using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneController : MonoBehaviour
{
    public float radius = 80.0f;
    public float speed = 0.03f;

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
            ZoomTarget.target_tag = 9;
            TimeScale.header = "Neptune";
            TimeScale.info = "Mass: 102 * 10^24 kg\nDiameter: 49528 km\nGravity: 11.0 m/s^2\nDistance from Sun: 4515 * 10^6 km";
        }
    }
}
