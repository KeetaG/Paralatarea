using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo : MonoBehaviour
{
    public GameObject CuboPrueba;
    public ColorCapsula vboolcapsula;
    public ColorEsfera vboolesfera;
    public bool variable3;
    private void Awake()
    {
       

    }
    // Start is called before the first frame update
    void Start()
    {
        vboolcapsula.variable1 = true;
        vboolesfera.variable2 = true;
        variable3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (vboolcapsula && vboolesfera && variable3 == true)
        {
            CuboPrueba.GetComponent<MeshRenderer>().material.color = Color.white;
            variable3 = false;
            
        }
        else
        {
            CuboPrueba.GetComponent<MeshRenderer>().material.color = Color.black;
            variable3 = true;
        }



    }
}
