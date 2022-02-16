using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : SingletonMonoBehaviour<CardManager>
{
    [SerializeField,Tooltip("CardのPrefubの配列")] 
    GameObject[] _cardPrefubs = default;

    /// <summary> カードPrefubについている、CardControllerを入れる配列</summary>
    CardController[] _cardControllers = default;

    [SerializeField,Tooltip("BoxのPanel")] 
    GameObject _boxPanel = default;
    [SerializeField, Tooltip("TeamのPanel")] 
    GameObject _teamPanel = default;

    [SerializeField, Tooltip("Boxのtag")]
    string _Box = "Box";
    [SerializeField, Tooltip("Teamのtag")]
    string _Team = "Team";


    static List<bool> _isTeams = new List<bool>();

    public static List<bool> IsTeams { get => _isTeams; set => _isTeams = value; }

    void Start()
    {
        //配列のSizeを決める
        _cardControllers = new CardController[_cardPrefubs.Length];

        SetTeam();
        DontDestroyOnLoad(this);
    }
    
    /// <summary>
    /// カードがTeamにいるかを判断して、生成する関数
    /// </summary>
    public void SetTeam()
    {
        //CardPrefubの数、for文を回す
        for (int i = 0; i < _cardPrefubs.Length; i++)
        {
            GameObject go = Instantiate(_cardPrefubs[i], _boxPanel.transform);  //i番目を生成する、とりあえずboxPanelに生成する
            _cardControllers[i] = go.GetComponent<CardController>(); //生成したカードについているコンポーネントを取得

            if (_cardControllers[i].IsTeam)　//コンポーネントにあるフラグがtrueの場合
            {
                _cardControllers[i].gameObject.transform.SetParent(_teamPanel.transform);　//適当な場所にあるカードを仕分け
                IsTeams.Add(true);
            }
            else
            {
                _cardControllers[i].gameObject.transform.SetParent(_boxPanel.transform);
                IsTeams.Add(false);
            }
            Debug.Log($"{i}番目は{_isTeams[i]}");
        }
    }
    public void ChangeTeam(GameObject card,int num,Transform box,Transform team)
    {

            if (_cardControllers[num].gameObject.transform.parent.gameObject.tag == _Box)　//コンポーネントにあるフラグがtrueの場合
            {
                card.transform.SetParent(team);
                IsTeams[num] = true;
            }
            else
            {
                card.transform.SetParent(box);
                IsTeams[num] = false;
            }
            Debug.Log($"{card.name}は{_isTeams[num]}");
        
    }
}
