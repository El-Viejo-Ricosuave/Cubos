using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo1 : MonoBehaviour
{

    public GameObject cubo1;
    private Material Material;

    bool Variable = false;

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
        if (Variable == true)
        {
            Variable = false;
            GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            Variable = true;
            GetComponent<Renderer>().material.color = Color.white;
        }

    }


}
