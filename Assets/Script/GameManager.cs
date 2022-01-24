using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>ボタンの効果音</summary>
    [SerializeField] AudioSource _audio;

    //GameStart_"Select"にシーン遷移
    public void GameStart()
    {
        //_audio.Play();
        SceneManager.LoadScene("Select");
    }

    public void Stage1()
    {
        _audio.Play();
        SceneManager.LoadScene("Battle1");
    }
}
