using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _enemyHp = 20;
    [SerializeField] float _defence = 3;

    public void GetDamage(float damege)
    {
        _enemyHp -= Mathf.Abs(Defence - damege);
        if(_enemyHp <= 0)
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
