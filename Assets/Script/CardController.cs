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
    bool _IsTeam;

    [SerializeField] int _number;

    private void Awake()
    {
        //PanelのTransformを取得
        _teamPanelTransform = GameObject.FindGameObjectWithTag(_Team).transform;
        _boxPanelTransform = GameObject.FindGameObjectWithTag(_Box).transform;
    }
    public void OnClick()
    {
        ////相手側のPanelの子オブジェクトにする
        //if (transform.parent.gameObject.tag == _Box)
        //{ 
        //    this.transform.SetParent(_teamPanelTransform);
        //    IsTeam = true;
        //}
        //else
        //{
        //    this.transform.SetParent(_boxPanelTransform);
        //    IsTeam = false;
        //}
        CardManager.Instance.ChangeTeam(this.gameObject,_number, _boxPanelTransform, _teamPanelTransform);
    }
    /// <summary>
    ///Teamにはいっているか判断するflag
    /// </summary>

    public int Number
    {
        get { return _number; }
    }

    public bool IsTeam { get => _IsTeam; set => _IsTeam = value; }
}