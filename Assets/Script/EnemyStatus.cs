using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour,IDamage
{
    [SerializeField] float _enemyMaxHp = 20;
    [SerializeField] float _defence = 3;
    [SerializeField] float _currentHp = 20;

    [SerializeField] GameObject _damageUI = default;
    [SerializeField] GameObject _posObj = default;
    [SerializeField] Vector3 _adjPos = default;

    public void GetDamage(float damege)
    {
        _enemyMaxHp -= Mathf.Abs(Defence - damege);

        Instantiate(_damageUI);
        _damageUI.GetComponent<TextMesh>().text = (_currentHp - _enemyMaxHp).ToString();
        _damageUI.transform.position = _posObj.transform.position + _adjPos;
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
