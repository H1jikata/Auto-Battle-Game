using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _enemyMaxHp = 20;
    [SerializeField] float _defence = 3;
    [SerializeField] float _currentHp = 20;


    public void GetDamage(float damege)
    {
        _enemyMaxHp -= Mathf.Abs(Defence - damege);
        Debug.Log(_enemyMaxHp);
        if (_enemyMaxHp <= 0)
        {
            Debug.Log("Enemyを倒した");
            Destroy(this.gameObject);
        }
    }

    public float Defence
    {
        get { return _defence; }
    }
}
