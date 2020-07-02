using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject playerpatlama;
    public GameObject patlama;

    GameObject OyunKontrol;
    OyunKontrol kontrol;
    
    void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<OyunKontrol> ();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "mermi")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.ScoreArttir(10);
        }
        if (col.tag == "Player")
        {
            Destroy(col.gameObject);
            Instantiate(playerpatlama, col.transform.position, col.transform.rotation);
            kontrol.GameOver();
        }

    }
}
