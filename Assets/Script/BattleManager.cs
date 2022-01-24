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

    CardController _cardCon;
    void Start()
    {
        PlayerSpawn();
        EnemySpown();
    }

    void PlayerSpawn()
    {
        for (int i = 0; i < _players.Length; i++)
        {
            _cardCon = _card[i].GetComponent<CardController>();

            if (_cardCon.IsTeam == false)
            {
                Instantiate(_players[i], _playerSpawns[i]);
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
}


