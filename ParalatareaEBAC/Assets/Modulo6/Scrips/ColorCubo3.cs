using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo3 : MonoBehaviour
{
    public GameObject cubotarea2;
    public ColorCubo vboolcubo1;
    public ColorCubo2 vboolcubo2;
    public bool variable6;
    // Start is called before the first frame update
    void Start()
    {
        vboolcubo1.variable3 = true;
        vboolcubo2.variable4 = true;
        variable6 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if ((vboolcubo1 && vboolcubo2) && variable6 == true)
        {
            cubotarea2.GetComponent<MeshRenderer>().material.color = Color.white;
            variable6 = false;

        }
        else
        {
            cubotarea2.GetComponent<MeshRenderer>().material.color = Color.black;
            variable6 = true;
        }
    }
}
