using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chara : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 6f;
    float LimitSpeed = 8f;
    public GameObject ChangePlayer2;
    bool JumpTrigger = false;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (GameMane.changeOn == true&& GameMane.SceneCheck == true)
        {
            GameMane.SceneCheck = false;
            GameMane.changeOn = false;
            GameObject obj = Instantiate(ChangePlayer2);
            var pos = this.transform.position;
            pos.x = GameMane.WX;
            pos.y = GameMane.WY;
            obj.transform.position = /*this.transform.position*/pos;
            Destroy(this.gameObject,0.1f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        CameraController.CameraX = this.transform.position.x;
        CameraController.CameraY = this.transform.position.y;


        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, rb.velocity.y);
        }
        float x = Input.GetAxis("Horizontal") * speed;
        float y = 300;
        Vector2 force = new Vector2(x, 0);    // ?͂??ݒ?
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reset" || collision.gameObject.tag == "rocher")
        {
            GameMane.ResetON = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reset" || collision.gameObject.tag == "rocher")
        {
            GameMane.ResetON = true;
        }
        if (collision.gameObject.tag == "Stagechange1")
        {
            CameraController.R = 73;
            CameraController.G = 111;
            CameraController.B = 70;
        }
        if (collision.gameObject.tag == "Check")
        {
            GameMane.WX = collision.gameObject.transform.position.x;
            GameMane.WY = collision.gameObject.transform.position.y;
            GameMane.changeOn = true;
            //GameMane.CheckPoint = collision.gameObject;
        }
        if (collision.gameObject.tag == "Stage" || collision.gameObject.tag == "Block"||collision.gameObject.tag == "Jump")
        {
            JumpTrigger = false;
        }
    }
}
