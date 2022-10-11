using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int valor1 = 1;
    float valor2 = 1;
    float valor3 = 10;
    float valor4 = 2;
    float resultado;
    int cambio = 0;
    int valor5 = 50;
    int valor6 = 15;
    public GameObject colorcapsula;
    // Start is called before the first frame update
    void Start()
    {
        resultado = valor3 - valor4;
        Debug.Log("El resultado es"+ resultado);

    }

    // Update is called once per frame
    void Update()
    {
        valor1 *= 2;
        Debug.Log(valor1);
    }

    private void FixedUpdate()
    {
        valor2 *= 2;
        Debug.Log(valor2);
        cambio = Random.Range(valor5 , valor6);
        if (cambio %2 == 0)
        {
            Debug.Log("El numero " +cambio+ "es par");
            colorcapsula.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            Debug.Log("El numero " + cambio + "es non");
            colorcapsula.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

    }
}
