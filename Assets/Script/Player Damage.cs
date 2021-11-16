using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] float _hp = 50;

    void Damage()
    {
        float rnd = Random.Range(10, 15);
        
    }

    public float HP
    {
        get{ return _hp; }
        set{ _hp = value; }
    }

}
