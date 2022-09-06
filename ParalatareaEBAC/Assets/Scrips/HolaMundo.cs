using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        Debug.Log("Hola gente");
        Debug.LogWarning("Así es como se muestra una advertencia");
        Debug.LogError("Y así es como se muestra un error en Unity");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);
    }
}
