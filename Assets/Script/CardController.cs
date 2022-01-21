using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField,Tooltip("Boxのtag")] 
    string _Box = "Box";
    [SerializeField,Tooltip("Teamのtag")]
    string _Team = "Team";

    /// <summary>相手側のPanelのTransform</summary>
    Transform _boxPanelTransform = default;
    /// <summary>相手側のPanelのTransform</summary>
    Transform _teamPanelTransform = default;

    private void Start()
    {
        //PanelのTransformを取得
        _teamPanelTransform = GameObject.FindGameObjectWithTag(_Team).transform;
        _boxPanelTransform = GameObject.FindGameObjectWithTag(_Box).transform;
    }
    public void OnClick()
    {
        //相手側のPanelの子オブジェクトにする
        if(transform.parent.gameObject.tag == _Box)
        {
            this.transform.SetParent(_teamPanelTransform);
        }
        else
        {
            this.transform.SetParent(_boxPanelTransform);
        }
    }
}
