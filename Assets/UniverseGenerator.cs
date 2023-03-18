using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseGenerator : MonoBehaviour
{   

    //set a hash string for the seed
    
    public string seed;

    public GameObject player;

    public int numberOfStars;
    Vector3[] points;
    public float radius;

    void Start()
    {   
        Random.InitState(seed.GetHashCode());
        GenerateStars();

       // GenerateCoordinateSystem();
    }

    void GenerateCoordinateSystem(){
        // OFFSET THE COORDINATE SYSTEM BY HALF THE RADIUS OF THE UNIVERSE
        Vector3 offset = new Vector3(radius / 2, radius / 2, radius / 2);
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 10 - 1; j >= 0; j--)
            {
                for (int k = 0; k < 10; k++)
                {
                    Vector3 point = new Vector3(i * 100, j * 100, k * 100);
                    if (i < 9)
                    {
                        Vector3 point2 = new Vector3((i + 1) * 100, j * 100, k * 100);
                        GameObject lineObject = new GameObject();
                        lineObject.AddComponent<LineRenderer>();
                        LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();
                        lineRenderer.material.color = Color.white;
                        lineRenderer.startWidth = 1f;
                        lineRenderer.endWidth = 1f;
                        lineRenderer.SetPosition(0, point - offset);
                        lineRenderer.SetPosition(1, point2 - offset);
                        lineObject.name = "line" + i + j + k;
                    }
                    if (j < 9)
                    {
                        Vector3 point2 = new Vector3(i * 100, (j + 1) * 100, k * 100);
                        GameObject lineObject = new GameObject();
                        lineObject.AddComponent<LineRenderer>();
                        LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();
                        lineRenderer.material.color = Color.white;
                        lineRenderer.startWidth = 1f;
                        lineRenderer.endWidth = 1f;
                        lineRenderer.SetPosition(0, point - offset);
                        lineRenderer.SetPosition(1, point2 - offset);
                        lineObject.name = "line" + i + j + k;
                    }
                    if (k < 9)
                    {
                        Vector3 point2 = new Vector3(i * 100, j * 100, (k + 1) * 100);
                        GameObject lineObject = new GameObject();
                        lineObject.AddComponent<LineRenderer>();
                        LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();
                        lineRenderer.material.color = Color.white;
                        lineRenderer.startWidth = 1f;
                        lineRenderer.endWidth = 1f;
                        lineRenderer.SetPosition(0, point - offset);
                        lineRenderer.SetPosition(1, point2 - offset);
                        lineObject.name = "line" + i + j + k;
                    }
                }
            }
        }
    }

    Mesh createPointMesh(float radius)
    {
        int divisions = 1;
        Sphere sphere = SphereCreator.Create(divisions, radius, "World");
        return sphere.Render();
    }
       

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 23);
        }
    }



    void GenerateStars()
    {
        Vector3[] starPoints = GeneratePointsWithinSphere();
        for (int i = 0; i < starPoints.Length; i++)
        {
            StarDefiner starDefiner = new StarDefiner();
            StarCategory starCategory = starDefiner.Define();
            Star star = new Star(starCategory.dominateColor, starPoints[i], starCategory.mass, starCategory.radius, starCategory.highTemperature, starCategory.highLuminosity, starCategory.galaxyName + i );
            star.transform.parent = transform;
        }
    }



    Vector3[] GeneratePointsWithinSphere()
    {
        points = new Vector3[numberOfStars];
        for (int i = 0; i < numberOfStars; i++)
        {
            Vector3 point = Random.insideUnitSphere * radius;
            points[i] = point;
        }
        return points;
    }

    void GeneratePoints()
    {
        points = new Vector3[numberOfStars];
        for (int i = 0; i < numberOfStars; i++)
        {
            float angle = Random.Range(0, 2 * Mathf.PI);
            float elevation = Random.Range(0, Mathf.PI);
            float x = radius * Mathf.Sin(elevation) * Mathf.Cos(angle);
            float y = radius * Mathf.Sin(elevation) * Mathf.Sin(angle);
            float z = radius * Mathf.Cos(elevation);
            points[i] = new Vector3(x, y, z);
        }
    }

    //visualise points
    void OnDrawGizmos2()
    {
        Gizmos.DrawWireSphere(Vector3.zero, radius);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 2);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 4);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 8);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 16);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 32);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 64);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 128);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 256);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 512);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 1024);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 2048);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 4096);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 8192);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 16384);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 32768);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 65536);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 131072);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 262144);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 524288);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 1048576);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 2097152);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 4194304);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 8388608);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 16777216);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 33554432);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 67108864);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 134217728);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 268435456);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 536870912);
        Gizmos.DrawWireSphere(Vector3.zero, radius / 1073741824);
    }
}
