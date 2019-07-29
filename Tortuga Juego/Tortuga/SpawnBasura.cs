using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasura : MonoBehaviour
{
    public GameObject BasuraPrefab;
    public float TiempoGener = 1.75f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CrearEnem", 0f, TiempoGener);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearEnem()
    {
        Instantiate(BasuraPrefab, transform.position, Quaternion.identity);
    }


}
