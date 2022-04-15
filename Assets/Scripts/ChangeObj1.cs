using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObj1 : MonoBehaviour
{
    public GameObject ChangeObject2;
    Rigidbody2D rb;
    float speed = 70.0f;
    bool CircleCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CircleCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GameObject obj = Instantiate(ChangeObject2);
                obj.transform.position = this.transform.position;
                Destroy(this.gameObject,0.1f);

            }
        }
    }
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            float x = Input.GetAxis("Horizontal") * speed;
            Vector2 force = new Vector2(x, 0.0f);    // óÕÇê›íË
            rb.AddForce(force);
        }
        if(collision.gameObject.tag == "circle")
        {
            CircleCheck = true;
            
        }
        if (collision.gameObject.tag == "SoftPlayer")
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "circle")
        {
            CircleCheck = false;
        }
        if(collision.gameObject.tag == "SoftPlayer")
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
    
}
