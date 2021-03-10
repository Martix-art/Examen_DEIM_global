using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class huevo : MonoBehaviour
   
{
    int nrotos = 0;
    [SerializeField] Text rotos;
    // Start is called before the first frame update
    void Start()
    {
        rotos = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        rotos.text = "huevos rotos: " + nrotos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            nrotos += 1;
        }
        Destroy(gameObject);

    }

}
