using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEsfera : MonoBehaviour
{
    public GameObject EsferaPrueba;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color esfera = new Color(Random.value, Random.value, Random.value);
        EsferaPrueba.GetComponent<MeshRenderer>().material.color = esfera;
    }
}
