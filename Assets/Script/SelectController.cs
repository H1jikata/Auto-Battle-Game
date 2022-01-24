using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectController : MonoBehaviour
{
    [SerializeField] string _formationScene = "";
    [SerializeField] string _exitScene = "";
    void Update()
    {
        if (Input.GetButtonDown("Character"))
        {
            SceneManager.LoadScene(_formationScene, LoadSceneMode.Additive);
        }

        if(Input.GetButtonDown("Cancel"))
        {
            SceneManager.UnloadSceneAsync(_exitScene);
        }
    }
}
