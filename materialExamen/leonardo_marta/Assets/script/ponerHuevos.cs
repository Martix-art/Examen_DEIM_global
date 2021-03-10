using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ponerHuevos : MonoBehaviour
{
    [SerializeField] GameObject huevo;
    float interval = 1f;
    public float speed = 10f;
    private float randomNumber;
    private Vector3 RandomPos;
    [SerializeField] Transform InitPos;

    // Start is called before the first frame update
    void Start()
    {
        MasHuevos();
        //Lanzo la corrutina 

        StartCoroutine("InstaHuevo");


    }

    // Update is called once per frame
    void Update()
    {
       // interval -= speed * Time.deltaTime;
    }
    IEnumerator InstaHuevo()
    {
        randomNumber = Random.Range(-170, 170f);
        RandomPos = new Vector3(randomNumber, 0, randomNumber);
        print(RandomPos);
        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(huevo, FinalPos, Quaternion.identity);
        yield return new WaitForSeconds(interval);
    }

    IEnumerator MasHuevos()
    {
        //Bucle infinito 
        for  (int n = 0; ;n ++ )
        {
            InstaHuevo();
            yield return null;
        }

    }
}
