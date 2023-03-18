using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRandomizer
{
    public float mass;
    public float radius;
    public float temperature;
    public float luminosity;

    public StarRandomizer()
    {
        this.mass = Random.Range(1f, 100f);
        this.radius = Random.Range(1f, 100f);
        this.temperature = Random.Range(0, 1000000);
        this.luminosity = Random.Range(1f, 100f);
    }
}