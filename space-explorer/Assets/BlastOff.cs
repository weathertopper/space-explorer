using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BlastOff : MonoBehaviour
{

    public List<AstroBody> solarSystem;
    // public GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        solarSystem = new List<AstroBody>();
        solarSystem.Add(new AstroBody("moon", new Vector3(1.0f, 1.0f, 1.0f), 1, 1));
        solarSystem.Add(new AstroBody("other moon", new Vector3(-3.0f, -3.0f, -3.0f), 2, 2));
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello Update!");

        foreach (AstroBody astroBody in solarSystem)
        {
            print(astroBody.body.name + " " + astroBody.mass);
        }
    }
}