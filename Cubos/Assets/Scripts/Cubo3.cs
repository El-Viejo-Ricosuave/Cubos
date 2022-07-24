using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo3 : MonoBehaviour
{
    public GameObject cubo3;
    private Material Material;

    bool variable = false;
    bool variable2 = true;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (variable == true || variable2 == false)
        {
            variable = false;
            GetComponent<Renderer>().material.color = Color.black;
            variable2 = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            variable = true;
            GetComponent<Renderer>().material.color = Color.white;
            variable2 = false;
            GetComponent<Renderer>().material.color = Color.black;
        }
    }

}


