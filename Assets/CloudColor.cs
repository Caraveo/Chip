using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudColor : MonoBehaviour
{
    void Start()
    {
        Color color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1f);
        GetComponent<ParticleSystem>().startColor = color;
    }
}
