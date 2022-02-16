using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _playerHp = 100;
    [SerializeField] float _defense = 5;
    [SerializeField] float _currentHp = 100;
    Slider _slider;

    private void Start()
    {
        _slider = GameObject.Find("HPber").GetComponent<Slider>();
    }
    public void DefenceChange(float value)
    {
        _defense += value;
    }

    public void GetDamage(float damage)
    {
        _playerHp -= Mathf.Abs(damage - Defence);
        _slider.value = _playerHp;
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
