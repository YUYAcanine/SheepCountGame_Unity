using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartDirector : MonoBehaviour
{
    public void EasyButton()
    {
        SceneManager.LoadScene("GameSceneEasy");
    }
    public void DifficultButton()
    {
        SceneManager.LoadScene("GameSceneDifficult");
    }
    
}
