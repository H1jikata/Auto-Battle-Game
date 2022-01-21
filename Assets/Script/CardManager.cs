using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField,Tooltip("CardのPrefubの配列")] 
    GameObject[] _cardPrefubs = default;

    /// <summary> カードPrefubについている、CardControllerを入れる配列</summary>
    CardController[] _cardControllers = default;

    [SerializeField,Tooltip("BoxのPanel")] 
    GameObject _boxPanel = default;
    [SerializeField, Tooltip("TeamのPanel")] 
    GameObject _teamPanel = default;
    void Start()
    {
        //配列のSizeを決める
        _cardControllers = new CardController[_cardPrefubs.Length];

        SetTeam();
    }
    /// <summary>
    /// カードがTeamにいるかを判断して、生成する関数
    /// </summary>
    void SetTeam()
    {
        //CardPrefubの数、for文を回す
        for (int i = 0; i < _cardPrefubs.Length; i++)
        {
            GameObject go = Instantiate(_cardPrefubs[i], _boxPanel.transform);  //i番目を生成する、とりあえずboxPanelに生成する
            _cardControllers[i] = go.GetComponent<CardController>(); //生成したカードについているコンポーネントを取得

            if (_cardControllers[i].IsTeam)　//コンポーネントにあるフラグがtrueの場合
            {
                _cardControllers[i].gameObject.transform.SetParent(_teamPanel.transform);　//適当な場所にあるカードを仕分け
            }
            else
            {
                _cardControllers[i].gameObject.transform.SetParent(_boxPanel.transform);
            }
        }
    }
}
