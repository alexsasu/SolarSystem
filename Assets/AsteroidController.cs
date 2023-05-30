using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float startingRadius;
    public float finishingRadius;
    [Range(1,1200)]
    public int asteroidNumber;
    public GameObject[] asteroidTemplates;
    void Start()
    {
        if (startingRadius > finishingRadius)
        {
            float tempo = startingRadius;
            startingRadius = finishingRadius;
            finishingRadius = tempo;
        }
        SpawnAroundPoint();
    }

    private void SpawnAsteroid(GameObject asteroid, Vector3 position)
    {
        GameObject go = Instantiate(asteroid);
        go.transform.SetParent(transform, false);
        go.transform.localPosition = position;
        Vector3 rotationAngles = new Vector3(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
        go.transform.Rotate(rotationAngles, Space.Self);
   
    }

    public void SpawnAroundPoint()
    {
        for (int i = 0; i < asteroidNumber; i++)
        {
            var radians = 2 * Mathf.PI / asteroidNumber * i;

            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);

            var spawnDirection = new Vector3(horizontal, Random.Range(-0.1f, 0.1f), vertical); // 8.7

            var distanceStartFinish = Mathf.Abs(finishingRadius - startingRadius);

            var spawnPosition = Vector3.zero + spawnDirection * (startingRadius + Random.Range(0, distanceStartFinish));
            SpawnAsteroid(asteroidTemplates[Random.Range(0, asteroidTemplates.Length - 1)], spawnPosition);
        }
    }
    
}
