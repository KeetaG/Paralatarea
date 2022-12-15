using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listanumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> HashSetInts = new HashSet<int>();
    Queue<string> colaString = new Queue<string>();
    Dictionary<string, float> poderarmas = new Dictionary<string, float>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            listanumeros.Add(Random.Range(0,20));
        }
        foreach (var numero in listanumeros)
        {
            Debug.Log(numero);
        }
        listanumeros.Sort();
        foreach (var numero in listanumeros)
        {
            Debug.Log(numero);
        }
        listaStrings.Add("Mario");
        listaStrings.Add("Fernanda");
        listaStrings.Add("Abigail");
        listaStrings.Add("Grecia");
        listaStrings.Add("Thomas");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        listaStrings.RemoveAt(2);
       
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
    }

    void Update()
    {
        
    }
}