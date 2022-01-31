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
        for (int i = 0; i < CardManager.IsTeams.Count; i++)
        {
            //_cardCon = _card[i].GetComponent<CardController>();


            if (CardManager.IsTeams[i] == true && CardManager.IsTeams.Count != 0)
            {
                Instantiate(_players[i], _playerSpawns[i]);
                Debug.LogError($"{_players[i].name}が出た！");
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


