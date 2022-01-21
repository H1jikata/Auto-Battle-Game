using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] float _hp = 100;
    [SerializeField] float _defense = 5;
   
    public void DefenceChange(float value)
    {
        _defense += value;
    }

    public float Defence
    {
        get { return _defense; }
    }

    public float Hp
    {
        get { return _hp; }
        set { _hp = value; }
    }
}
