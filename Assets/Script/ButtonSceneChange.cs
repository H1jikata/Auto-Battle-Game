using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{
    public void SceneChange(string scnene)
    {
        foreach (var i in CardManager.IsTeams)
        {
            if (i == false)
            {
                continue;
            }
            SceneManager.LoadScene(scnene);
        }
    }
}
