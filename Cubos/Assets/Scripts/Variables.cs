using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    bool Variable1 = true;
    private Renderer ColorCubo;

    // Start is called before the first frame update
    void Start()
    {
        if (Variable1 = true)
        {
            ColorCubo = GetComponent<Renderer>();
            ColorCubo.material.SetColor("_Color", Color.green);

        }
        else Variable1 = false;
        {
            ColorCubo = GetComponent<Renderer>();
            ColorCubo.material.SetColor("_Color", Color.red);
        } 
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
