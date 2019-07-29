using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTortuga : MonoBehaviour

{
    public float velocidad;
    // public float FuerzaSalto;

    //private bool Salto;
    private Rigidbody Jugador;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()

    {


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocidad, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-velocidad, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, velocidad, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -velocidad, 0) * Time.deltaTime);
        }

    }
}






//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MovTortuga : MonoBehaviour
//{
//    public float moveSpeed = 10f;
//    public float turnSpeed = 50f;


//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKey(KeyCode.UpArrow))
//            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

//        if (Input.GetKey(KeyCode.DownArrow))
//            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

//        if (Input.GetKey(KeyCode.LeftArrow))
//            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

//        if (Input.GetKey(KeyCode.RightArrow))
//            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

//    }
//}