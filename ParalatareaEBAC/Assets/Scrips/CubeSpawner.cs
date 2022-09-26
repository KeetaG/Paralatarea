using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject Cubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
     
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempoGameObject = Instantiate<GameObject>(Cubo);
        tempoGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempoGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempoGameObject.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(tempoGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
