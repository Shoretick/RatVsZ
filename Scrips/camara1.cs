using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara1 : MonoBehaviour
{
    public GameObject target;
    private Vector3 distancia;
    // Start is called before the first frame update
    void Start()
    {
        distancia= transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position= target.transform.position+ distancia;
    }
}
