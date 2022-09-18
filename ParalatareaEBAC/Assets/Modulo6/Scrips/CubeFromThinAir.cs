using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFromThinAir : MonoBehaviour
{
    GameObject CuboDesde0;
    Vector3[] vertices =
        {
        new Vector3 (0, 0, 0), //Veritce 0
        new Vector3 (1, 0, 0), //Vertice 1
        new Vector3 (1, 1, 0), //Vertice 2
        new Vector3 (0, 1, 0), //Vertice 3
        new Vector3 (0, 1, 1), //Vertice 4
        new Vector3 (1, 1, 1), //Vertice 5
        new Vector3 (1, 0, 1), //Vertice 6
        new Vector3 (0, 0, 1), //Vertice 7
    };

    int[] triangulos =
    {
        0, 2, 1, //cara 1
        0, 3, 2,
        2, 3, 4, //cara 2
        2, 4, 5,
        1, 2, 5, //cara 3
        1, 5, 6,
        0, 7, 4, //cara 4
        0, 4, 3,
        5, 4, 7, //cara 5
        5, 7, 6,
        0, 6, 7, //cara 6
        0, 1, 6,
    };
    private void Awake()
    {
        CuboDesde0 = new GameObject("Cubo para la tarea M6");
        CuboDesde0.AddComponent<MeshFilter>();
        var meshFilter = CuboDesde0.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        CuboDesde0.AddComponent<BoxCollider>();
        var boxCollider = CuboDesde0.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        CuboDesde0.AddComponent<MeshRenderer>();
        var meshRenderer = CuboDesde0.GetComponent<MeshRenderer>().material;
        meshRenderer.color = Color.black;
        CuboDesde0.transform.position = Vector3.one;
        CuboDesde0.AddComponent<Rigidbody>();
        
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
