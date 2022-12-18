using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listanumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> HashSetInts = new HashSet<int>();
    Queue<string> colaString = new Queue<string>();
    Stack<string> pilaString = new Stack<string>();
    Dictionary<string, float> poderarmas = new Dictionary<string, float>();
    // Start is called before the first frame update
    void Start()
    {
        DemoDictionary("Escopeta");
        DemoDictionary("Espada");
    }

    void Update()
    {
        
    }

    public void DemoListas()
    {
        for (int i = 0; i < 20; i++)
        {
            listanumeros.Add(Random.Range(0, 20));
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
    public void DemoHashSet()
    {
        for (int i = 0; i < 20; i++)
        {
            HashSetInts.Add(i);
        }
        if (HashSetInts.Contains(5))
        {
            HashSetInts.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no contiene este elemento");
        }
    }
    public void DemoCola()
    {
        ///First In First Out = FIFO
        colaString.Enqueue("Proyectil 1");
        colaString.Enqueue("Proyectil 2");
        colaString.Enqueue("Proyectil 3");
        colaString.Enqueue("Proyectil 4");
        colaString.Enqueue("Proyectil 5");
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
        Debug.Log(colaString.Peek());
        colaString.Dequeue();
    }

    public void DemoStack()
    {
        ///First In Last Out = FILO
        pilaString.Push("As");
        pilaString.Push("CincoEspadas");
        pilaString.Push("Tres Corazones");
        pilaString.Push("CuatroTrebol");
        pilaString.Push("ReyEspadas");
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
    }
    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if (!poderarmas.ContainsKey("Rifle"))
        {
            poderarmas.Add("Rifle", 7.0f);
        }
        if (!poderarmas.ContainsKey("Pistola"))
        {
            poderarmas.Add("Pistola", 3.0f);
        }
        if (!poderarmas.ContainsKey("Escopeta"))
        {
            poderarmas.Add("Escopeta", 5.0f);
        }
        if (!poderarmas.ContainsKey("RifleFrancotirador"))
        {
            poderarmas.Add("RifleFrancotirador", 10.0f);
        }
        if (!poderarmas.ContainsKey("Cuchillo"))
        {
            poderarmas.Add("Cuchillo", 2.0f);
        }
    
        if (poderarmas.TryGetValue(arma, out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
    }
}