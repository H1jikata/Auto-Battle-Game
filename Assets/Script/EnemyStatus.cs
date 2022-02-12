using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _enemyHp = 20;
    [SerializeField] float _defence = 3;
    GameObject _enemy;
    bool Isdestroyflg = false;

    private void Update()
    {
        if(Isdestroyflg)
        {
            Finish();
        }
    }
    public void GetDamage(float damege)
    {
        _enemyHp -= Mathf.Abs(Defence - damege);
        if (_enemyHp <= 0)
        {
            Isdestroyflg = true;
        }
    }

    void Finish()
    {
        if (_enemyHp <= 0)
        {
            Debug.Log("Enemyを倒した");
            _enemy = this.gameObject;
            Destroy(_enemy);
        }
    }

    public float Defence
    {
        get { return _defence; }
    }
}
