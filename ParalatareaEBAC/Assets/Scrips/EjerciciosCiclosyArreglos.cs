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
    int limite3 = 0;
    int limite4 = 0;
    int contador5 = 0;
    int f = 0;
    string h;
    string j;
<<<<<<< HEAD
    int k = 0;
    int q = 0;
    int l = 0;
    int w = 0;
    int r = 0;
    int b = 0;
    int suma = 0;
=======
>>>>>>> Main
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
        string[] c = new string[3] { "Hola ", "A ", "Todos" };
        for (int f = 0; f < c.Length; f++)
        {
            j = c[f];
        }
        foreach (string j in c)
        {
            h += j;
        }
        Debug.Log(h);
        

        int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int k = 0; k < matriz.GetLength(0); k++)
        {
            for (int l = 0; l < matriz.GetLength(1); l++)
            {
                Debug.Log("Numeros de matriz 1 " + matriz[k, l]);
            }
        }
<<<<<<< HEAD
        int[,] matriz2 = new int[1,3] { { 5, 4, 3 } };
=======
        int[] matriz2 = new int[3] { { 5, 4, 3 } };
>>>>>>> Main
        for (int q = 0; q < matriz2.GetLength(0); q++)
        {
            for (int w = 0; w < matriz2.GetLength(1); w++)
            {
                Debug.Log("Numeros de matriz 2 " + matriz2[q, w]);
            }
        }
        
<<<<<<< HEAD
=======

>>>>>>> Main
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
