﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField,Tooltip("次の行動までの時間")] float _coolTime = 0;
    [SerializeField,Tooltip("コルーチンの待つ時間")] float _reset = 1;
    [SerializeField,Tooltip("攻撃するEnemyのGameObject")] GameObject _enemy = default;
    bool _flg = false;
    Animator _ani;
    Enemy _enemyHp;
    IDamage _damage;
    void Start()
    {
        _ani = GetComponent<Animator>();
        _enemyHp = GetComponent<Enemy>();
    }

    void Update()
    {
        _coolTime += Time.deltaTime;
        if (_coolTime > 4.5f && _flg == false)
        {
            Attack();
        }
    }

    void Attack()
    {
        if (_enemy)
        {
            int rnd = Random.Range(1, 10);
            if (rnd < 5)
            {
                _ani.SetBool("Attack", true);
                StartCoroutine("CoolTime");
                _flg = true;
                var _damageTarget = _enemy.GetComponent<IDamage>();
                if(_damageTarget != null)
                {
                    _enemy.GetComponent<IDamage>().GetDamage(rnd);
                }
            }
            else
            {
                _ani.SetBool("Attack2", true);
                StartCoroutine("CoolTime1");
                _flg = true;
                var _damageTarget = _enemy.GetComponent<IDamage>();
                if (_damageTarget != null)
                {
                    _enemy.GetComponent<IDamage>().GetDamage(rnd);
                }
            }
        }
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(_reset);
        _ani.SetBool("Attack", false);
        _coolTime = 0;
        _flg = false;
    }

    private IEnumerator CoolTime1()
    {
        yield return new WaitForSeconds(_reset);
        _ani.SetBool("Attack2", false);
        _coolTime = 0;
        _flg = false;
    }
}
