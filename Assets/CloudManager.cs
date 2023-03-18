using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
    public GameObject cloudPrefab;
    public int cloudCount = 100;
    public int radius = 100;
    void Start()
    {
        GenerateClouds(cloudPrefab);
    }

    void GenerateClouds(GameObject cloudPrefab)
    {
        for (int i = 0; i < cloudCount; i++)
        {
            GameObject cloud = Instantiate(cloudPrefab, new Vector3(Random.Range(-radius, radius), Random.Range(-radius, radius), Random.Range(-radius, radius)), Quaternion.identity);
            cloud.transform.parent = transform;
        }
    }

}
