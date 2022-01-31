using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : SingletonMonoBehaviour<ChangeScene>
{
    // Start is called before the first frame update
    [SerializeField] float _time = 1f;
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SceneChange(string scenename)
    {
       StartCoroutine(Scene(scenename)) ;
    }
    IEnumerator Scene(string scene)
    {
        yield return new WaitForSeconds(_time);
        SceneManager.LoadScene(scene);
    }
}
