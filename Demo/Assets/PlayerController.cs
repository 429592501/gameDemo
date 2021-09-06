using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;//获取刚体对象
    public Animator anim;//获取动画控制器


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    //角色移动
    void Run() {
        float moveX = Input.GetAxis("Horizontal");
        float dirX = Input.GetAxisRaw("Horizontal");
        if (moveX != 0)
        {
            rb.velocity = new Vector2(moveX * playerSpeed, rb.velocity.y);
            anim.SetBool("runing", true);
            if (dirX != 0) {
                transform.localScale = new Vector3(dirX,1,1);
            }
          
        }
        else 
        {
            anim.SetBool("runing", false);
        }
        
    }
}
