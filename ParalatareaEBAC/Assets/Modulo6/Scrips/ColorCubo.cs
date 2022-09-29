using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo : MonoBehaviour
{
    public GameObject CuboPrueba;
    public GameObject conexion1;
    bool variable3;
    bool variable4; 
    private void Awake()
    {
        //Color cubo = new Color(Random.value, Random.value, Random.value);
        //CuboPrueba.GetComponent<MeshRenderer>().material.color = cubo;
    }
    // Start is called before the first frame update
    void Start()
    {

        conexion1.GetComponent<ColorCapsula>();
        conexion1.GetComponent<ColorEsfera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //Color capsula = new Color(Random.value, Random.value, Random.value);
        //Capsulaprueba.GetComponent<MeshRenderer>().material.color = capsula;

        if (variable3 == true)
        {
            CuboPrueba.GetComponent<MeshRenderer>().material.color = Color.white;
            variable3 = false;
        }
        else if (variable3 == false)
        {
            CuboPrueba.GetComponent<MeshRenderer>().material.color = Color.black;
            variable3 = true;
        }



    }
}
