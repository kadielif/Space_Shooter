using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinirlar : MonoBehaviour
{
   
   void OnTriggerExit(Collider col)
    {
        if (col.tag == "mermi")
        {
            Destroy(col.gameObject);
        }
    }
}
