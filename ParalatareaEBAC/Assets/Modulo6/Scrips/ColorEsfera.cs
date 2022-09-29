using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEsfera : MonoBehaviour
{
    public GameObject EsferaPrueba;
    bool variable2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Color capsula = new Color(Random.value, Random.value, Random.value);
        //Capsulaprueba.GetComponent<MeshRenderer>().material.color = capsula;

        if (variable2 == true)
        {
            EsferaPrueba.GetComponent<MeshRenderer>().material.color = Color.white;
            variable2 = false;
        }
        else if (variable2 == false)
        {
            EsferaPrueba.GetComponent<MeshRenderer>().material.color = Color.black;
            variable2 = true;
        }



    }
}
