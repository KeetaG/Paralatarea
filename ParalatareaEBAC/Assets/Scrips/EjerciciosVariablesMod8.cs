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
    int liminf = 0;
    int limisup = 2;
    int valorswitch = 2;
    string unstring = "Blanco";
    string dostring = "Negro";
    float numero = 3.14159f;
    string valor7;  
    enum palabra 
    {
        unstring,
        dostring
    }
    public GameObject colorcapsula;
    // Start is called before the first frame update
    void Start()
    {
        resultado = valor3 - valor4;
        Debug.Log("El resultado es " + resultado);
        valorswitch = Random.Range(liminf, limisup);
        switch (valorswitch)
        {
            case (int)palabra.unstring:
                colorcapsula.GetComponent<MeshRenderer>().material.color = Color.white;
                Debug.Log("El color seleccionado es " + unstring);
                break;
            case (int)palabra.dostring:
                colorcapsula.GetComponent<MeshRenderer>().material.color = Color.black;
                Debug.Log("El color seleccionado es " + dostring);
                break;
        }
        string exflt = numero.ToString();
        Debug.Log("Este es tu numero " + (string.Format(exflt, "{0:0.0000}", numero)));

        string minombrecom = "Mario Barcena Calderon";
        string minombre = minombrecom.Substring(0, 5);
        string miapellidopat = minombrecom.Substring(6, 8);
        string miapellidomat = minombrecom.Substring(10, 12);
        Debug.Log(minombrecom);
        Debug.Log(minombre);
        Debug.Log(miapellidopat);
        Debug.Log(miapellidomat);

        char misletras;
        string frase = "Hola Mundo";
        
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
            Debug.Log("El numero " +cambio+ " es par");
            colorcapsula.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            Debug.Log("El numero " + cambio + " es non");
            colorcapsula.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

    }
}
