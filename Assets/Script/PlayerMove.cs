using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove :  SingletonMonoBehaviour<PlayerMove>
{
    [SerializeField,Tooltip("次の行動までの時間")] float _coolTime = 0;
    [SerializeField, Tooltip("Ultの時間")] float _ultTime = 0.01f;
    [SerializeField] float _sliderHp = 0;
    [SerializeField,Tooltip("コルーチンの待つ時間")] float _reset = 1;
    [SerializeField] float _reset1 = 1;
    [SerializeField] float _coolfirst = 4.5f;

    [SerializeField,Tooltip("攻撃するEnemyのName")] string _enemyName = "";
    [SerializeField, Tooltip("enemyのspawnのName")] string _spawnName = "";
    GameObject _enemy;
    bool IsAttack = false;
    bool IsUlt = default;
    Animator _ani;
    Enemy _enemyHp;
    IDamage _damage;
    Slider _ultTimeSlider;
    Button _ultButtton;
    void Start()
    {
        _ani = GetComponent<Animator>();
        _enemyHp = GetComponent<Enemy>();
        _ultTimeSlider = GameObject.Find("Ultber (2)").GetComponent<Slider>();
        _ultButtton = GameObject.Find("CutInButton").GetComponent<Button>();
        _ultButtton.interactable = false;
        FindEnemy();
    }

    void Update()
    {
        _coolTime += Time.deltaTime;
        //_ultTime += Time.deltaTime;
        if (_coolTime > _coolfirst && IsAttack == false)
        {
            Attack();
        }

        if(IsUlt == true)
        {
            _sliderHp = _ultTimeSlider.minValue;
            _ultTimeSlider.value = _sliderHp;
            _ultTime = 0.01f;
            _ultButtton.interactable = false;
            IsUlt = false;
        }
        _sliderHp += _ultTime;
        if(_sliderHp >= _ultTimeSlider.maxValue)
        {
            _ultTime = 0f;
            _sliderHp += _ultTime;
            _ultButtton.interactable = true;
        }
        _ultTimeSlider.value = _sliderHp;
    }

    void Attack()
    {
        if (_enemy)
        {
            float rnd = Random.Range(1, 10);
            if (rnd < 5)
            {
                _ani.SetBool("Attack", true);
                StartCoroutine("CoolTime");
                IsAttack = true;
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
                IsAttack = true;
                var _damageTarget = _enemy.GetComponent<IDamage>();
                if (_damageTarget != null)
                {
                    _enemy.GetComponent<IDamage>().GetDamage(rnd);
                }
            }
        }
    }

    public void Ult()
    {
        float rnd = Random.Range(20, 30);
        IsUlt = true;
        IsAttack = true;
        _ani.SetBool("UltAttack", true);
        _enemy.GetComponent<IDamage>().GetDamage(rnd);
        StartCoroutine(CoolTime2());
    }

    void FindEnemy()
    {
        GameObject _a = GameObject.Find(_spawnName);
        _enemy = _a.transform.Find(_enemyName).gameObject;
    }
    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(_reset);
        _ani.SetBool("Attack", false);
        _coolTime = 0;
        IsAttack = false;
    }

    private IEnumerator CoolTime1()
    {
        yield return new WaitForSeconds(_reset);
        _ani.SetBool("Attack2", false);
        _coolTime = 0;
        IsAttack = false;
    }

    private IEnumerator CoolTime2()
    {
        yield return new WaitForSeconds(1.5f);
        _ani.SetBool("UltAttack", false);
        _coolTime = 0;
        IsAttack = false;
    }
}
