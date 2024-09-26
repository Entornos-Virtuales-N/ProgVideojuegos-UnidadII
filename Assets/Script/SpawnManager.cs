using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animales;

    void Start()
    {
        InvokeRepeating("SpawnAnimales", 5, 0.5F);
    }

    // Update is called once per frame
    void Update()
    {

    }
        //Crea los animales en automatico
    void SpawnAnimales()
    {
            int indice = Random.Range(0, animales.Length);
            int rango = Random.Range(-20, 20);
            Vector3 pos = new Vector3(rango,0,30);
            Instantiate(animales[indice],pos, 
                animales[indice].transform.rotation);
    }
}
