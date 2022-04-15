using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 3f;
    float LimitSpeed = 7f;
    public GameObject ChangePlayer2;
    bool JumpTrigger = false;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, rb.velocity.y);
        }
        float x = Input.GetAxis("Horizontal") * speed;
        float y = 300;
        Vector2 force = new Vector2(x, 0);    // �͂�ݒ�
        rb.AddForce(force);
        if (Input.GetKeyDown(KeyCode.Space)&&JumpTrigger ==false)
        {
            rb.AddForce(new Vector2(0,y));
            JumpTrigger = true;
        }
        rb.velocity *= 0.98f;

        if(en.WhiteCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GameObject obj = Instantiate(ChangePlayer2);
                obj.transform.position = this.transform.position;
                Destroy(this.gameObject, 0.1f);

            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stage" || collision.gameObject.tag == "Block")
        {
            JumpTrigger = false;
        }
    }
}
