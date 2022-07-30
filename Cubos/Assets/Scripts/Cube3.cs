using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3 : MonoBehaviour
{
    public Cube1 cube1;
    public Cube2 cube2;
    public bool Var3;


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
        if (cube1.Var1 || cube2.Var2) 
        {
            Var3 = true;
            GetComponent<Renderer>().material.color = Color.white;

        }
        else
        {
            Var3 = false;
            GetComponent<Renderer>().material.color = Color.black;

        }

    }
}
