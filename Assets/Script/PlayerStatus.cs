using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _maxHp = 100;
    [SerializeField] float _defense = 5;
    [SerializeField] float _currentHp = 100;

    [SerializeField] string _sliderName = "";
    Slider _slider;


    private void Start()
    {
        _slider = GameObject.Find(_sliderName).GetComponent<Slider>();
        _currentHp = _maxHp;
        _slider.value = _currentHp;
    }
    public void DefenceChange(float value)
    {
        _defense += value;
    }

    public void GetDamage(float damage)
    {
        _currentHp -= Mathf.Abs(damage - Defence);
        _slider.value = _currentHp;

        if(_currentHp <= 0)
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
        get { return _maxHp; }
        set { _maxHp = value; }
    }
}
