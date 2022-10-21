using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosCiclosyArreglos : MonoBehaviour
{
    int contador = 3;
    int contador2 = 3;
    int contador3 = 3;
    int limitsup = 10;
    int limitinf = 0;
    int limite1 = 0;
    int limite2 = 10;
    int x;
    int y;
    int contador4 = 3;
    int limite3 = 0;
    int limite4 = 0;
    int contador5 = 0;
    // Start is called before the first frame update
    void Start()
    {
        //int[] arreglo1 = new int[contador];
        //for (int x = 0; x < arreglo1.Length; x++) 
        //{
        //   arreglo1[x] = contador = Random.Range(limitinf, limitsup);
        //    Debug.Log("Numeros del arreglo 1 " + arreglo1[x]);
        //    contador--;
        //}

        //int[] arreglo2 = new int[contador2];
        //for (int y = 0; y < arreglo2.Length; y++)
        //{
        //    arreglo2[y] = contador = Random.Range(limite1, limite2);
        //    Debug.Log("Numeros del arreglo 2 " + arreglo2[y]);
        //    contador2--;
        //}

        //int[] arreglo3 = new int[contador3];
        //for (int z = 0; z < arreglo3.Length; z++)
        //{
        //    arreglo3[z] = arreglo1[x] + arreglo2[y];
        //    Debug.Log("Numeros de arreglo 3 " + arreglo3[z]);
        //    x++;
        //    y++;
        //    contador3--;
        //}
        //string[] c = new string[3] { "Hola", "A", "Todos" };
        //int[] arreglo4 = new int[contador4];
        //for (int a = 0; a < c.Length; a++) 
        //{
        //   arreglo4[a] = a + 1;
        //    Debug.Log(c[a]);
        //}
        //foreach (string j in c)
        //{
        //    Debug.Log(j);
        //}
        int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int k = 0; k < matriz.GetLength(0); k++)
        {
            for (int l = 0; l < matriz.GetLength(1); l++)
            {
                Debug.Log("Numeros de matriz 1 " + matriz[k, l]);
            }
        }
        int[] arreglo5 = new int[contador5];
        for (int b = 0; b < arreglo5.Length; b++)
        {
            arreglo5[b] = contador5 = Random.Range(limite3, limite4);
            Debug.Log("Numeros para multiñlicación " + arreglo5[b]);
            contador5--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
