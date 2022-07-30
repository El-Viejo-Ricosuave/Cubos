using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube4 : MonoBehaviour
{
    public Cube1 cube1;
    public Cube2 cube2;
    public bool Var4;


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
        if (cube1.Var1 && cube2.Var2)
        {
            Var4 = true;
            GetComponent<Renderer>().material.color = Color.white;

        }
        else
        {
            Var4 = false;
            GetComponent<Renderer>().material.color = Color.black;

        }

    }
}
