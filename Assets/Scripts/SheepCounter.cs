using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheepCounter : MonoBehaviour
{
    GameObject Number;
    Text textComponent;

    void Start()
    {
        this.textComponent = GetComponent<Text>(); // Textコンポーネントを取得
        this.Number = GameObject.Find("Number");
        
    }

    void Update()
    {
        // SheepCountの値をテキストに表示
        this.Number.GetComponent<Text>().text = "羊が" + Sheep2Generator.SheepCount + "匹"; // UIに初期値を設定
    }
}



