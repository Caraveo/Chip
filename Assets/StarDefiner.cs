using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDefiner
{   

    public StarCategory Define()
    {
        return DefineStarCategory();
    }


    StarCategory DefineStarCategory(){
        StarRandomizer starRandom = new StarRandomizer();
        if (starRandom.mass >= 1f && starRandom.radius >= 1f && starRandom.temperature >= 3500f && starRandom.temperature <= 5500f && starRandom.luminosity >= 1f && starRandom.luminosity <= 10f){
            return new StarCategory(StarType.StarTypes.YellowDwarf, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Yellow Dwarf", Color.yellow);
        } 
        if (starRandom.mass >= 1f && starRandom.radius >= 1f && starRandom.temperature >= 5500f && starRandom.temperature <= 10000f && starRandom.luminosity >= 1f && starRandom.luminosity <= 50f){

            return new StarCategory(StarType.StarTypes.WhiteDwarf, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "White Dwarf", Color.white);
        } 
        if (starRandom.mass >= 2f && starRandom.radius <= 10f && starRandom.temperature >=10000f && starRandom.temperature <= 30000f && starRandom.luminosity >= 0.5f && starRandom.luminosity <= 20f){

            return new StarCategory(StarType.StarTypes.BlueGiant, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Blue Giant", Color.blue);
        } 
        if (starRandom.mass >= 10f && starRandom.radius <= 100f && starRandom.temperature >= 30000f && starRandom.temperature <= 100000f && starRandom.luminosity >= 20f && starRandom.luminosity <= 100f){
            return new StarCategory(StarType.StarTypes.SuperGiant, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Super Giant", Color.cyan);
        } 
        if (starRandom.mass >= 20f && starRandom.radius <= 100f && starRandom.temperature >= 100000f && starRandom.temperature <= 300000f && starRandom.luminosity >= 10f && starRandom.luminosity <= 100f){
            return new StarCategory(StarType.StarTypes.WolfRayet, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "wolf-Rayet", Color.magenta);
        } 
        if (starRandom.mass >= 1.4f && starRandom.radius >= 10f && starRandom.temperature >= 300000f && starRandom.temperature <= 600000f && starRandom.luminosity >= 100f && starRandom.luminosity <= 100f){
            return new StarCategory(StarType.StarTypes.NeutronStar, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Neutron Star", Color.gray);
        } 
        if (starRandom.mass >= 3f && starRandom.radius >= 10f && starRandom.temperature >= 600000f && starRandom.temperature <= 1000000f && starRandom.luminosity >= 0f && starRandom.luminosity <= 100f){
            return new StarCategory(StarType.StarTypes.BlackHole, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Black Hole", Color.black);
        } 
        else if (starRandom.mass >= 1f && starRandom.radius >= 2f && starRandom.temperature >= 2000f && starRandom.temperature <= 3500f && starRandom.luminosity >= 0f && starRandom.luminosity <= 1f){
        StarType.StarTypes randomStarType = (StarType.StarTypes)Random.Range(8, System.Enum.GetValues(typeof(StarType.StarTypes)).Length);
        return new StarCategory(randomStarType, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Brown Dwarf", new Color(0.5f, 0.25f, 0f));
        } else {
            return new StarCategory(StarType.StarTypes.RedDwarf, starRandom.mass, starRandom.radius, starRandom.temperature, starRandom.temperature, starRandom.luminosity, starRandom.luminosity, "Red Dwarf", Color.red);
        } 
    }
}