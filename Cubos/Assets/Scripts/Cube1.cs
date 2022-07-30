using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    public GameObject cubo;
    public bool Var1 = true;


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
        if (Var1 == false)
        {
            Var1 = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            Var1 = false;
            GetComponent<Renderer>().material.color = Color.black;
        }


    }

}
