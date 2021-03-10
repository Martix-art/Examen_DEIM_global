using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movcubo : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject cesta;
    private bool quitarCesta = false;
    

    [SerializeField] Text recogidos;

    
    int nrecogidos = 0;

    // Start is called before the first frame update
    void Start()
    {
        cesta.SetActive(quitarCesta);

        
        recogidos = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        //desactivar la cesta
        if (cesta.activeInHierarchy == false)
        {
            MoverCubo();
        }

        Cesta();

        
        recogidos.text = "huevos recogidos: " + nrecogidos;


    }
    //activar con el boton la cesta
    void Cesta()
    {
        if (Input.GetButtonDown("RB"))
        {
            quitarCesta = !quitarCesta;
            cesta.SetActive(quitarCesta);
            
        }
        
    }

    void MoverCubo()
    {

        float desplX = Input.GetAxis("Vertical");
        if (transform.position.x < -190f && desplX > 0)
        {
            desplX = 0f;
        }
        else if (transform.position.x > 190f && desplX < 0)
        {
            desplX = 0f;
        }

        float desplZ = Input.GetAxis("Horizontal");

        if (transform.position.z < -190f && desplZ < 0)
        {
            desplZ = 0f;
        }
        else if (transform.position.z > 190f && desplZ > 0)
        {
            desplZ = 0f;
        }
        
        
        //Movemos la nave mediante el método transform.translate
        //Lo multiplicamos por deltaTime, el eje y la velocidad de movimiento la nave
        //Space.World es lo que hace que la nave gire entorno a su eje al realizar los giros
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed * desplX);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * desplZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "huevo")
        {
            nrecogidos += 1;
        }
    }

}