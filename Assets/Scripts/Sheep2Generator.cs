using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep2Generator : MonoBehaviour
{   
    public GameObject SheepPrefab;
    float minSpawnInterval = 0.15f; // 最小の生成間隔
    float maxSpawnInterval = 2.0f; // 最大の生成間隔
    float nextSpawnTime; // 次の生成時間
    public static int SheepCount = 0;
    GameObject player; // player変数を宣言

    void Start()
    {
        this.player = GameObject.Find("player");
        SetNextSpawnTime();
    }
    
    void Update()
    {
        if (player == null) // playerが見つからない場合は処理を終了
            return;

        Vector3 playerPos = this.player.transform.position;
        
        if(Time.time > nextSpawnTime && playerPos.x < 25 && playerPos.x > -5)
        {
            GameObject go = Instantiate(SheepPrefab);
            int py = Random.Range(-2,3);
            go.transform.position = new Vector3(13 + playerPos.x, py, 0);
            SetNextSpawnTime();

            // SheepCountをインクリメント
            SheepCount++;
        }
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }
}