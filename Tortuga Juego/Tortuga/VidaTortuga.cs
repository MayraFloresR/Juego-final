using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidaTortuga : MonoBehaviour

{
    public float vida;
    public Text vidaText;

    private void Start()
    {
        vidaText.text = vida.ToString();
    }

    private void Update()
    {
        vidaText.text = vida.ToString();
        if (vida <= 0)
        {
            Destroy(GameObject.Find("Tortuga"));
        }
    }


    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Basura")
        {
            vida -= 25;
        }

        if (collision.gameObject.tag == "Depredador")
        {
            vida -= 100;
        }

        if (collision.gameObject.tag == "Trampa")
        {
            vida -= 100;
        }

        if (collision.gameObject.tag == "Comida")
        {
            vida += 15;
        }
    }
}

