using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _hp = 100;
    [SerializeField] float _defense = 5;
    [SerializeField] int _speed = 10;
    [SerializeField] float _coolTime = 0;
    [SerializeField] float _reset = 1;
    [SerializeField] GameObject _enemy = null;
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

    void AnimEvent()
    {

    }
    public float Defence
    {
        get { return _defense; }
        set { _defense = value; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _defense = value; }
    }
}
