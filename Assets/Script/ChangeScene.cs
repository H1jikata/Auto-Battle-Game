using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : SingletonMonoBehaviour<ChangeScene>
{
    [SerializeField] float _time = 1f;
    /// <summary>ボタンの効果音</summary>
    [SerializeField] AudioSource _audio;
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SceneChange(string scenename)
    {
        _audio.Play();
       StartCoroutine(Scene(scenename)) ;
    }

    public void SceneChanges(string scenename)
    {
        StartCoroutine(Scene(scenename));
    }

    IEnumerator Scene(string scene)
    {
        yield return new WaitForSeconds(_time);
        SceneManager.LoadScene(scene);
    }
}
