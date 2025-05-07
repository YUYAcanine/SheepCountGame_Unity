using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    Rigidbody2D rigid2D;
    float walkForce = 30.0f;
    float maxWalkSpeed = 4.0f;
    float jumpForce = 550.0f;
    int key = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }
    
    public void UpButtonDown()
    {
        // 地面に接触している場合にのみジャンプする
        if (Mathf.Abs(this.rigid2D.velocity.y) < 0.1f)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
    }
    
    public void RButtonDown()
    {
        key = 1;
    }
    
    public void LButtonDown()
    {
        key = -1;
    }

    public void StopMoving()
    {
        key = 0;
    }

    void Update()
{
    if (key != 0)
    {
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
    }
    else if (Mathf.Abs(this.rigid2D.velocity.x) > 0.1f) // キーが押されていない場合に速度がある場合は減速
    {
        this.rigid2D.velocity *= new Vector2(0.5f, 1); // x方向の速度を減衰させる
    }

    if (transform.position.y < -10)
    {
        SceneManager.LoadScene("StartScene");
        Sheep2Generator.SheepCount = 0;
    }
}


    void OnTriggerEnter2D(Collider2D other)
    {

        SceneManager.LoadScene("EnterScene");
    }
}

