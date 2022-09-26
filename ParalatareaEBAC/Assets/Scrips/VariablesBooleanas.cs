using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limitein = -5;
    int limitesu = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }

    // A B C   OR  AND  ((A or B) and c))  ((A or B) or c))
    // 1 1 1    1   1            1                  1
    // 1 1 0    1   0            0                  1
    // 1 0 1    1   0            1                  1
    // 1 0 0    1   0            0                  1
    // 0 1 1    1   0            1                  1
    // 0 1 0    1   0            0                  1
    // 0 0 1    1   0            0                  1
    // 0 0 0    0   0            0                  0

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
       if ((variable1 || variable2) && variable3)
        {
            Debug.Log("la operacion 1 es verdadera");
            
        }
       if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("La variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es verdadera");
        }
       if((variable3 && variable2) || variable1)
        {
            Debug.Log("la operacion 3 es verdadera");
        }
        valor1 = Random.Range(limitein, limitesu);
        Debug.Log(valor1);
        //if(valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        Debug.Log(resultado);
       // switch(valor1)
        //{
          //  case (int)SeleccionColor.rojo:
            //    Debug.Log("El color es rojo");
              //  break;
            //case (int)SeleccionColor.verde:
              //  Debug.Log("El color es verde");
                //break;
            //case (int)SeleccionColor.azul:
              //  Debug.Log("El color es azul");
                //break;
            //case (int)SeleccionColor.blanco:
              //  Debug.Log("El color es blanco");
                //break;
            //case (int)SeleccionColor.gris:
              //  Debug.Log("El color es gris");
                //break;
            //default:
              //  Debug.Log("Ese no es un color valido");
                //break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
