using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    [SerializeField] Transform cuboCesta;
    private AudioSource general;

    // Start is called before the first frame update
    void Start()
    {
        general = GetComponent<AudioSource>();
        general.Play();

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cuboCesta);

        
        
        
    }
}
