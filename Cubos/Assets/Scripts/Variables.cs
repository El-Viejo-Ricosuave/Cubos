using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1;
    int limiteInferior=0;
    int limitesuperior=5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }


    // Start is called before the first frame update
    void Start()
    {

        variable1 = true;
        variable2 = false;
        variable3 = false;


        if ((variable1 || variable2) && variable3) 

            if ((variable1 || variable2) || variable3) 

                if ((variable3 || variable2) || variable1)


     valor1 = Random.Range(limiteInferior, limitesuperior);

        switch (valor1) 
        {
            case(int)SeleccionColor.rojo:
                Debug.Log("el color seleccionado es Rojo");
                break;
            case(int)SeleccionColor.verde:
                Debug.Log("el color seleccionado es Verde");
                break;
            case(int)SeleccionColor.azul:
                Debug.Log("el color seleccionado es Azul");
                break;
            case(int)SeleccionColor.gris:
                Debug.Log("el color seleccionado es Gris");
                break;
            case(int)SeleccionColor.blanco:
                Debug.Log("el color seleccionado es Blanco");
                break;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
