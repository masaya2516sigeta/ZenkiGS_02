using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charasoft : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 25f;
    float LimitSpeed = 35f;
    public GameObject ChangePlayer1;
    bool JumpTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraController.CameraX = this.transform.position.x;
        CameraController.CameraY = this.transform.position.y;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }


        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, rb.velocity.y);
        }
        float x = Input.GetAxis("Horizontal") * speed;
        float y = 2000;
        Vector2 force = new Vector2(x, 0);    // ?͂??ݒ?
        rb.AddForce(force);
        if (Input.GetKeyDown(KeyCode.Space) && JumpTrigger == false)
        {
            rb.AddForce(new Vector2(0, y));
            JumpTrigger = true;
        }
        rb.velocity *= 0.98f;

        if (en.WhiteCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GameObject obj = Instantiate(ChangePlayer1);
                obj.transform.position = this.transform.position;
                Destroy(this.gameObject, 0.1f);

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Check")
        {
            GameMane.WX = collision.gameObject.transform.position.x;
            GameMane.WY = collision.gameObject.transform.position.y;
            GameMane.changeOn = true;
            //GameMane.CheckPoint = collision.gameObject;
        }
        if (collision.gameObject.tag == "Stage" || collision.gameObject.tag == "Jump")
        {
            JumpTrigger = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Reset"||collision.gameObject.tag == "rocher")
        {
            GameMane.ResetON = true;
        }
        if (collision.gameObject.tag == "Stage" || collision.gameObject.tag == "Jump")
        {
            JumpTrigger = false;
        }
    }
}
