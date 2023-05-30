using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class SaturnController : MonoBehaviour
{
    public float radius = 170.0f;
    public float speed = 0.05f;

    //manual settings
    [Range(3, 360)]
    public int segments = 3;
    public float innerRadius = 0.7f;
    public float thickness = 0.5f;
    public Material ringMat;

    //cached references
    GameObject ring;
    Mesh ringMesh;
    MeshFilter ringMF;
    MeshRenderer ringMR;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = GetPosition(Time.time * speed);
    }

    void OnEnable()
    {
        if (ring == null || ringMesh == null)
        {
            SetUpRing();
        }
        BuildRingMesh();
    }

    void OnValidate()
    {
        if (ring == null || ringMesh == null)
        {
            SetUpRing();
        }
        BuildRingMesh();
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
            ZoomTarget.target_tag = 7;
            TimeScale.header = "Saturn";
            TimeScale.info = "Mass: 568 * 10^24 kg\nDiameter: 120536 km\nGravity: 9.0 m/s^2\nDistance from Sun: 1432.0 * 10^6 km";
        }
    }

    void SetUpRing()
    {
        //check if ring is null and there are no children
        if (ring == null && transform.childCount == 0)
        {
            //create ring object
            ring = new GameObject(name + "Ring");
            ring.transform.parent = transform;
            ring.transform.SetAsFirstSibling();
            ring.transform.localScale = Vector3.one;
            ring.transform.localPosition = Vector3.zero;
            ring.transform.localRotation = Quaternion.identity;
            ringMF = ring.AddComponent<MeshFilter>();
            ringMR = ring.AddComponent<MeshRenderer>();
            ringMR.material = ringMat;
        }
        else
        {
            ring = transform.GetChild(0).gameObject;
            ringMF = ring.GetComponent<MeshFilter>();
            ringMR = ring.GetComponent<MeshRenderer>();
        }
        ringMesh = new Mesh();
        ringMF.sharedMesh = ringMesh;
    }

    void BuildRingMesh()
    {
        //build ring mesh
        Vector3[] vertices = new Vector3[(segments + 1) * 2 * 2];
        int[] triangles = new int[segments * 6 * 2];
        Vector2[] uv = new Vector2[(segments + 1) * 2 * 2];
        int halfway = (segments + 1) * 2;

        for (int i = 0; i < segments + 1; i++)
        {
            float progress = (float)i / (float)segments;
            float angle = Mathf.Deg2Rad * progress * 360;
            float x = Mathf.Sin(angle);
            float z = Mathf.Cos(angle);

            vertices[i * 2] = vertices[i * 2 + halfway] = new Vector3(x, 0f, z) * (innerRadius + thickness);
            vertices[i * 2 + 1] = vertices[i * 2 + 1 + halfway] = new Vector3(x, 0f, z) * innerRadius;
            uv[i * 2] = uv[i * 2 + halfway] = new Vector2(progress, 0f);
            uv[i * 2 + 1] = uv[i * 2 + 1 + halfway] = new Vector2(progress, 1f);

            if (i != segments)
            {
                triangles[i * 12] = i * 2;
                triangles[i * 12 + 1] = triangles[i * 12 + 4] = (i + 1) * 2;
                triangles[i * 12 + 2] = triangles[i * 12 + 3] = i * 2 + 1;
                triangles[i * 12 + 5] = (i + 1) * 2 + 1;

                triangles[i * 12 + 6] = i * 2 + halfway;
                triangles[i * 12 + 7] = triangles[i * 12 + 10] = i * 2 + 1 + halfway;
                triangles[i * 12 + 8] = triangles[i * 12 + 9] = (i + 1) * 2 + halfway;
                triangles[i * 12 + 11] = (i + 1) * 2 + 1 + halfway;
            }
        }

        if (vertices.Length < ringMesh.vertices.Length)
        {
            ringMesh.triangles = triangles;
            ringMesh.vertices = vertices;
        }
        else
        {
            ringMesh.vertices = vertices;
            ringMesh.triangles = triangles;
        }
        ringMesh.uv = uv;
        ringMesh.RecalculateNormals();
    }
}
