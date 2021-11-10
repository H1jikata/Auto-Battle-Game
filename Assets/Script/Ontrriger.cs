using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontrriger : MonoBehaviour
{
    [SerializeField] GameObject _go = null;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {

        }
    }
}
