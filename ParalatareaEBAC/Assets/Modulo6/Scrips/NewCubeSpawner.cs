using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCubeSpawner : MonoBehaviour
{
    public GameObject cubes;
    public List<GameObject> cubelist;
    public float scalefactor;
    public int cubenum = 0;
    // Start is called before the first frame update
    void Start()
    {
        cubelist = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        cubenum++;
        GameObject crazycubes = Instantiate<GameObject>(cubes);
        Color cubos = new Color(1, 1, 1);
        crazycubes.GetComponent<MeshRenderer>().material.color = cubos;
        crazycubes.transform.position = Random.insideUnitSphere;

        cubelist.Add(crazycubes);
        List<GameObject> thingsToKill = new List<GameObject>();
        foreach (GameObject go in cubelist)
        {
            float scale = go.transform.localScale.x;
            scale *= scalefactor;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                thingsToKill.Add(go);
            }
        }

        foreach (GameObject go in thingsToKill)
        {
            cubelist.Remove(go);
            Destroy(go);
        }
    }
}
