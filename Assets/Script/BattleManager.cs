using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] GameObject[] _players = default;
    [SerializeField] GameObject[] _enemys = default;

    [SerializeField] Transform[] _spawns = default;

    CardController _cardCon;
    void Start()
    {
        for(int i = 0; i < _players.Length; i++)
        {
            _cardCon = _players[i].GetComponent<CardController>();

            if (_cardCon.IsTeam == true)
            {
                Instantiate(_players[i],_spawns[i]);
            }}
        }
    }


