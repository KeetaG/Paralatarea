using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCapsula : MonoBehaviour
{
    bool variable1;
    

    // A B C   OR  AND  ((A or B) and c))  ((A or B) or c))
    // 1 1 1    1   1            1                  1
    // 1 1 0    1   0            0                  1
    // 1 0 1    1   0            1                  1
    // 1 0 0    1   0            0                  1
    // 0 1 1    1   0            1                  1
    // 0 1 0    1   0            0                  1
    // 0 0 1    1   0            0                  1
    // 0 0 0    0   0            0                  0

    public GameObject Capsulaprueba;
    // Start is called before the first frame update
    void Start()
    {
        variable1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Color capsula = new Color(Random.value, Random.value, Random.value);
        //Capsulaprueba.GetComponent<MeshRenderer>().material.color = capsula;
        
        if (variable1 == true)
        { 
            Capsulaprueba.GetComponent<MeshRenderer>().material.color = Color.white;
            variable1 = false;
        }
        else if (variable1 == false)
        {
            Capsulaprueba.GetComponent<MeshRenderer>().material.color = Color.black;
            variable1 = true;
        }



    }
}
