using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFromThinAir : MonoBehaviour
{
    public GameObject cubefromair;
    private void Awake()
    {
        GameObject cuboalaire = Instantiate<GameObject>(cubefromair);
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
