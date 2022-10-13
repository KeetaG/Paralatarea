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
    string valor7 = "5000";
    string valor8 = "2000";
    string frase = "Hola Mundo";
    int fraseinf = 0;
    int frasesup = 10;
    int change = 0;
    char caracter;
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
        Debug.Log("Este es tu numero " + (string.Format(exflt, "{0:0.000}", numero)));

        string minombrecom = "Mario Barcena Calderon";
        int largo = minombrecom.Length;
        Debug.Log("Tu nombre tiene " + largo + " caracteres");
        string minombre = minombrecom.Substring(0, 5);
        string miapellidopat = minombrecom.Substring(6, 8);
        string miapellidomat = minombrecom.Substring(10, 12);
        string nombresplit = "Mario,Barcena,Calderon";
        string[] minombreporpartes = nombresplit.Split(',');
        Debug.Log(minombrecom);
        Debug.Log("Esto es m�todo SubString " + minombre);
        Debug.Log("Esto es m�todo SubString " + miapellidopat);
        Debug.Log("Esto es m�todo SubString " + miapellidomat);
        Debug.Log("Esto es metodo split " + minombreporpartes[0]);
        Debug.Log("Esto es metodo split " + minombreporpartes[1]);
        Debug.Log("Esto es metodo split " + minombreporpartes[2]);

        int valorentero1 = 0;
        int valorentero2 = 0;
        int resul = 0;
        int.TryParse(valor7, out valorentero1);
        int.TryParse(valor8, out valorentero2);
        resul = valorentero1 - valorentero2;
        Debug.Log("Este es tu resultado del tryparse " + resul);

        int fraselargo = frase.Length;
        Debug.Log("Tu frase tiene " + fraselargo + " caracteres");
        caracter = frase[2];

        string frasefinal = "Tarea-lista-EBAC!";
        string[] fraseporpartes = frasefinal.Split('-');
        Debug.Log("Frase de ultimo ejercicio: " + fraseporpartes[1]);
        Debug.Log("Frase de ultimo ejercicio: " + fraseporpartes[2]);
    }

    // Update is called once per frame
    void Update()
    {
        valor1 *= 2;
        Debug.Log(valor1);

        change = Random.Range(fraseinf , frasesup);
        if (change %2 == 0)
        {
            caracter = frase[change];
            Debug.Log("Este es tu caracter " + caracter);
        }
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
