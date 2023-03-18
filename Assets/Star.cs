using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star
{
    StarCategory starCategory;
    Color color;
    Vector3 coordinate;
    float mass;
    float radius;
    float temperature;
    float luminosity;
    string starName;

    GameObject starObject;
    public Transform transform;
    MeshRenderer meshRenderer;

    public Star(Color color, Vector3 coordinate, float mass, float radius, float temperature, float luminosity, string _name)
    {
        this.color = color;
        this.coordinate = coordinate;
        this.mass = mass;
        this.radius = radius;
        this.temperature = temperature;
        this.luminosity = luminosity;
        this.starName = _name;

        this.starObject = new GameObject();
        this.starObject.AddComponent<MeshFilter>().mesh = createStarMesh(radius);
        this.starObject.AddComponent<MeshRenderer>();

        //add mesh to meshrenderer
        this.meshRenderer = this.starObject.GetComponent<MeshRenderer>();
        this.meshRenderer.material.color = this.color;

        //add transform to gameobject
        this.transform = this.starObject.GetComponent<Transform>();
        this.transform.position = this.coordinate;

        //add name to gameobject
        this.starObject.name = this.starName;
        
        //scale this game object to .1
        this.transform.localScale = new Vector3(0.12f, 0.12f, 0.12f);
    }

    Mesh createStarMesh(float radius)
    {
        int divisions = 1;
        Sphere sphere = SphereCreator.Create(divisions, radius, "World");
        return sphere.Render();
    }

}
