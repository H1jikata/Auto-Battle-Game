using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] GameObject _a;
    IDamage _iDa;
    private void Start()
    {
        _iDa = _a.GetComponent<IDamage>();
    }
    private void OnTriggerEnter(Collider other)
    {
        IDamage d = other.gameObject.GetComponent<IDamage>();
        if (d != null)
        {
            //float set = _iDa.AddDamage();
            //d.GetDamage(set);
        }
    }
}
