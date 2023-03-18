using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCategory
{
    public StarType.StarTypes starType;
    public float mass;
    public float radius;
    public float lowTemperature;
    public float highTemperature;
    public float lowLuminosity;
    public float highLuminosity;
    public string galaxyName;
    public Color dominateColor;

    public StarCategory(StarType.StarTypes starStype, float mass, float radius, float lowTemperature, float highTemperature, float lowLuminosity, float highLuminosity, string _name, Color dominateColor)
    {
        this.starType = starStype;
        this.mass = mass;
        this.radius = radius;
        this.lowTemperature = lowTemperature;
        this.highTemperature = highTemperature;
        this.lowLuminosity = lowLuminosity;
        this.highLuminosity = highLuminosity;
        this.galaxyName = _name;
        this.dominateColor = dominateColor;
    }
}
