using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCapsula : MonoBehaviour
{
    public GameObject Capsulaprueba;
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
        Color capsula = new Color(Random.value, Random.value, Random.value);
        Capsulaprueba.GetComponent<MeshRenderer>().material.color = capsula;
        
    }
}
