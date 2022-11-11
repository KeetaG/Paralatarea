using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases : MonoBehaviour
{
    public float campo1;
    private bool campo2;
    protected float campo3 = 5;
    float campo4 = 4;
    // Start is called before the first frame update
    void Start()
    {
        campo1 = SumaFlotantes(campo3, campo4);
        Debug.Log(campo1);
        VuelveCeroAlNumero(out campo1);
        Debug.Log(campo1);
        ClaseNormal miClase = new ClaseNormal(campo3, campo4);
        campo1 = miClase.SumarFlotantes(campo3, campo4);
        Debug.Log(campo1);
        campo1 = ClaseNormal.MultiplicarFlotantes(campo3, campo4);
        Debug.Log(campo1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private float SumaFlotantes (float a, float b)
    {
        return a + b;
    }
    protected void VuelveCeroAlNumero(out float numero)
    {
        numero = 0;
    }
    public int propiedad1 { get; set; }

    public bool propiedad2 { get; set; }

    public float propiedadSoloLectura { get; }
}
