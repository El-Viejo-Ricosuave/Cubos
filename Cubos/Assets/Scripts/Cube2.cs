using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    public GameObject cubo;
    public bool Var2 = true;


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
        if (Var2 == false)
        {
            Var2 = true;
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            Var2 = false;
            GetComponent<Renderer>().material.color = Color.black;
        }


    }

}
