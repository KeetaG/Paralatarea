using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo paso amigo");
        
        Debug.LogWarning("Oh-oh revisa porque algo salio mal");
        Debug.LogError("UUUUUUPS algo salio muy mal amigo");
    }

    // Update is called once per frame
    void Update()
    {
        // x = x + 1;
        //Debug.Log(x);
        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde late update");
    }
    private void OnEnable()
    {
        Debug.Log("El objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.Log("El objeto a sido deshabilitado");
    }

}
