using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField, Tooltip("Boxのtag")]
    string _Box = "Box";
    [SerializeField, Tooltip("Teamのtag")]
    string _Team = "Team";

    /// <summary>相手側のPanelのTransform</summary>
    Transform _boxPanelTransform = default;
    /// <summary>相手側のPanelのTransform</summary>
    Transform _teamPanelTransform = default;

    //Teamにはいっているか判断するflag
    static bool _IsTeam = false;
    [SerializeField] bool test = false;

    [SerializeField] int _number;

    private void Awake()
    {
        _IsTeam = test;
        //PanelのTransformを取得
        _teamPanelTransform = GameObject.FindGameObjectWithTag(_Team).transform;
        _boxPanelTransform = GameObject.FindGameObjectWithTag(_Box).transform;
    }
    public void OnClick()
    {
        //相手側のPanelの子オブジェクトにする
        if (transform.parent.gameObject.tag == _Box)
        {
            this.transform.SetParent(_teamPanelTransform);
        }
        else
        {
            this.transform.SetParent(_boxPanelTransform);
        }
    }
    /// <summary>
    ///Teamにはいっているか判断するflag
    /// </summary>
    public bool IsTeam
    {
        get { return _IsTeam; }
        set { _IsTeam = value; }
    }

    public int Number
    {
        get { return _number; }
    }
}