using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo : MonoBehaviour
{
    public GameObject CuboPrueba;
    private void Awake()
    {
        Color cubo = new Color(Random.value, Random.value, Random.value);
        CuboPrueba.GetComponent<MeshRenderer>().material.color = cubo;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
