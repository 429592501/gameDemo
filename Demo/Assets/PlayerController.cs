using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;//��ȡ�������


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    //��ɫ�ƶ�
    void Run() {
        float moveX = Input.GetAxis("Horizontal");
        
        if (moveX != 0) {
            rb.velocity = new Vector2(moveX * playerSpeed, rb.velocity.y );
        }
        
    }
}
