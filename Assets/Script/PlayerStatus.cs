using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _playerHp = 100;
    [SerializeField] float _defense = 5;
    [SerializeField] float _currentHp = 100;
    [SerializeField] Slider _slider = default;

    private void Start()
    {
        //HPゲージを満タンにする
        //_slider.value = 1;
        //_currentHp = _playerHp;
    }
    public void DefenceChange(float value)
    {
        _defense += value;
    }

    public void GetDamage(float damage)
    {
        _playerHp = Mathf.Abs(damage - Defence);
        Debug.Log(_playerHp);

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
