using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo2 : MonoBehaviour
{
    public GameObject cubotarea;
    public bool variable4;
    public bool variable5;
    // Start is called before the first frame update
    void Start()
    {
        variable4 = false;
        variable5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (variable4 || variable5)
        {
            cubotarea.GetComponent<MeshRenderer>().material.color = Color.white;
            variable4 = false;
        }
        else if (variable4 == false || variable5 == false)
        {
            cubotarea.GetComponent<MeshRenderer>().material.color = Color.black;
            variable4 = true;
        }
    }
}
