using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Algo paso amigo");
        Debug.Log("Algo anda mal");
        Debug.LogWarning("Oh-oh revisa porque algo salio mal");
        Debug.LogError("UUUUUUPS algo salio muy mal amigo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
