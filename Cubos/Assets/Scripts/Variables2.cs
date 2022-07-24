using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables2 : MonoBehaviour
{
    bool Variable2 = true;
    private Renderer ColorCubo;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        {
            if (Variable2 = false)
            {
                Variable2 = true;
                ColorCubo = GetComponent<Renderer>();
                ColorCubo.material.SetColor("_Color", Color.red);

            }
            else Variable2 = true;
            {
                Variable2 = false;
                ColorCubo = GetComponent<Renderer>();
                ColorCubo.material.SetColor("_Color", Color.green);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
