using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;

    // A B C   OR  AND  ((A or B) and c))  ((A or B) or c))
    // 1 1 1    1   1            1                  1
    // 1 1 0    1   0            0                  1
    // 1 0 1    1   0            1                  1
    // 1 0 0    1   0            0                  1
    // 0 1 1    1   0            1                  1
    // 0 1 0    1   0            0                  1
    // 0 0 1    1   0            0                  1
    // 0 0 0    0   0            0                  0

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
       if ((variable1 || variable2) && variable3)
        {
            Debug.Log("la operacion 1 es verdadera");
            
        }
       if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("La variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es verdadera");
        }
       if((variable3 && variable2) || variable1)
        {
            Debug.Log("la operacion 3 es verdadera");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
