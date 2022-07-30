using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube5 : MonoBehaviour
{
    public Cube1 Cube1;
    public Cube2 cube2;
    public Cube3 Cube3;

    bool Var5;
    

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
        if ((Cube1.Var1 && cube2.Var2) || Cube3.Var3)
        {
            Var5 = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            Var5 = false;
            GetComponent<Renderer>().material.color = Color.black;
        }

            
    }


}

