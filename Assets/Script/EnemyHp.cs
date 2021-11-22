using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour,IDamage
{
    [SerializeField] float _enemyHp = 20;

    public void GetDamage(float damege)
    {
        _enemyHp -= damege;
        if(_enemyHp <= 0)
        {
            Debug.Log("Enemyを倒した");
            Destroy(this.gameObject);
        }
    }
}
