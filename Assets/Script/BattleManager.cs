using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] GameObject[] _players = default;
    [SerializeField] GameObject[] _enemys = default;
    [SerializeField] GameObject[] _card = default;

    [SerializeField] Transform[] _playerSpawns = default;
    [SerializeField] Transform[] _enemySpawns = default;

    [SerializeField] GameObject _ultPanel = default;
    [SerializeField] GameObject _ultPanel1 = default;
    [SerializeField] float _reset = default;
    void Start()
    {
        PlayerSpawn();
        EnemySpown();
    }

    void PlayerSpawn()
    {
        for (int i = 0; i < CardManager.IsTeams.Count; i++)
        {
            if (CardManager.IsTeams[i] == true && CardManager.IsTeams.Count != 0)
            {
                Instantiate(_players[i], _playerSpawns[i]);
                Debug.Log($"{_players[i].name}が出た！");
            }
        }
    }

    void EnemySpown()
    {
        for(int i = 0; i < _enemys.Length; i++)
        {
            Instantiate(_enemys[i], _enemySpawns[i]);
        }
    }

    public void Players()
    {
        PlayerMove.Instance.Ult();
        StartCoroutine(Panel());
    }

    private IEnumerator Panel()
    {
        yield return new WaitForSeconds(_reset);
        _ultPanel.SetActive(false);
    }

    public void Players1()
    {
        PlayerMove.Instance.Ult();
        StartCoroutine(Panel1());
    }

    private IEnumerator Panel1()
    {
        yield return new WaitForSeconds(_reset);
        _ultPanel1.SetActive(false);
    }
}


