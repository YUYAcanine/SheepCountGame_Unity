using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheepCounter3 : MonoBehaviour
{
    GameObject Number;
    Text textComponent;

    void Start()
    {
        this.textComponent = GetComponent<Text>(); // Textコンポーネントを取得
        this.Number = GameObject.Find("Number3");
        
    }

    void Update()
    {
        // SheepCountの値をテキストに表示
        this.Number.GetComponent<Text>().text = "ざんねん！せいかいは" + Sheep2Generator.SheepCount + "匹！"; // UIに初期値を設定
    }
}