
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasyon : MonoBehaviour
{

    Rigidbody fizik;
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
