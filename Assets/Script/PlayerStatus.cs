using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _playerHp = 100;
    [SerializeField] float _defense = 5;
    [SerializeField] int _playerNumber = default;
   
    public void DefenceChange(float value)
    {
        _defense += value;
    }

    public void GetDamage(float damage)
    {
        _playerHp = Mathf.Abs(damage - Defence);

        if(_playerHp <= 0)
        {
            Debug.Log("Playerがやられた");
            Destroy(this.gameObject);
        }
    }

    public float Defence
    {
        get { return _defense; }
    }

    public float Hp
    {
        get { return _playerHp; }
        set { _playerHp = value; }
    }
}
