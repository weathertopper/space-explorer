using System;
using UnityEngine;

public class AstroBody
{

    public GameObject body;
    public float mass;

    public AstroBody(string name, Vector3 startPos, float diameter, float density)
    {
        this.body = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        this.body.name = name;
        this.body.transform.position = startPos;
        this.body.transform.localScale = new Vector3(diameter, diameter, diameter);
        float radius = (float) (diameter / 2);
        float volume = (float) (( 4 * Math.PI * radius * radius * radius) / 3 );
        this.mass = density * volume;
    }
}
