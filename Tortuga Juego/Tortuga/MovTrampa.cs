using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTrampa : MonoBehaviour
{

    private Vector3 originalTransform;
    public float velocidad;
    public float distancia;

    // Start is called before the first frame update

    void Start()
    {
        originalTransform = this.transform.position;
    }

    // Update is called once per frame
    //Es necesario que la sierra gire, por lo que se multiplic el tiempo y la velocidad con una distancia de cero, por lo que la sierra rotará
    void Update()
    {
        transform.position = originalTransform + new Vector3(Mathf.Sin(Time.time * velocidad) * distancia, 0);

    }
}