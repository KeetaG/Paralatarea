using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cubosi = Instantiate<GameObject>(cubo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("El cubo esta en escena");
    }

    private void OnDisable()
    {
        Debug.Log("El cubo salió de la escena");
    }
}
