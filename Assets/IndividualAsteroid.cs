using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualAsteroid : MonoBehaviour
{
    private float speed = 0.1f;
    private float radius;
    // Start is called before the first frame update
    void Start()
    {
        radius = Mathf.Abs(transform.position.x) + Mathf.Abs(transform.position.z);
    }


    void Update()
    {
        this.transform.localPosition = GetPosition(Time.time * speed);
    }

    private Vector3 GetPosition(float angle)
    {
        return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
    }
}
