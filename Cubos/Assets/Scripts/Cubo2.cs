using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo2 : MonoBehaviour
{

    public GameObject cubo2;
    private Material Material;

    bool Variable = false;
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
        if (Variable == false || variable2 == true)
        {
            Variable = true;
            GetComponent<Renderer>().material.color = Color.white;
            variable2 = false;
            GetComponent<Renderer>().material.color = Color.black;

        }
        else
        {
            Variable = false;
            GetComponent<Renderer>().material.color = Color.black;
            variable2 = true;
            GetComponent<Renderer>().material.color = Color.white;



        }
    }

}
