using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClearDirector : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("StartScene");
        Sheep2Generator.SheepCount = 0;
    }


   //ゲーム終了:ボタンから呼び出す
    public void SleepButton()
    {
        Application.Quit();//ゲームプレイ終了
    }
}
