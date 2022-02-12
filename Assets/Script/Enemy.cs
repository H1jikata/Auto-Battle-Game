using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float _coolTime = 0;
    [SerializeField,Tooltip("次に行動できるまでの時間")] float _delayTime = 3f;
    [SerializeField,Tooltip("コルーチンの時間")] float _reset = 1;
    GameObject _enemyPlayer;
    bool _flg = false;
    Animator _ani;
    PlayerMove _playerMove;
    IDamage _damage;
    void Start()
    {
        _ani =  GetComponent<Animator>();
        _playerMove = GetComponent<PlayerMove>();
        FindEnemy();
    }

    void Update()
    {
        _coolTime += Time.deltaTime; 
        if(_coolTime > _delayTime && _flg == false)
        {
            Attack();
        }
    }

    void Attack()
    {
        if(_enemyPlayer)
        {
            float rnd = Random.Range(1, 10);
            if (rnd < 5)
            {
                _ani.SetBool("Attack", true);
                StartCoroutine(CoolTime());
                _flg = true;
                var _damageTarget = _enemyPlayer.GetComponent<IDamage>();
                if(_damageTarget != null)
                {
                    _enemyPlayer.GetComponent<IDamage>().GetDamage(rnd);
                }
            }
            else
            {
                _ani.SetBool("Attack2", true);
                StartCoroutine(CoolTime1());
                _flg = true;
                var _damageTarget = _enemyPlayer.GetComponent<IDamage>();
                if (_damageTarget != null)
                {
                    _enemyPlayer.GetComponent<IDamage>().GetDamage(rnd);
                }
            }
        }
    }

    void FindEnemy()
    {
        GameObject _a = GameObject.Find("PlayerSpown");
        _enemyPlayer = _a.transform.Find("red(Clone)").gameObject;
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
