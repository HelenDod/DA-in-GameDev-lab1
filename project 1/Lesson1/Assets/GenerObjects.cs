using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerObjects : MonoBehaviour
{
    public GameObject cube;
    public Transform spawn;
    public int countCubes;


    void Start()
    {
        countCubes = 0;
    }

    public void GenerateObj(string inputField)
    {
        countCubes = int.Parse(inputField);
        for (int i = 0; i < countCubes; ++i)
        {
            Instantiate(cube, spawn.position, cube.transform.rotation);
        }
    }
}
