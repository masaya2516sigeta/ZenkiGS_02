using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutaManager : MonoBehaviour
{
    HingeJoint2D hj;        //  HingeJoint用変数
    Rigidbody2D rb;         //  Rigidbody用変数
    // Start is called before the first frame update
    void Start()
    {
        hj = GetComponent<HingeJoint2D>();      //  hingejointを取得
        rb = GetComponent<Rigidbody2D>();       //  rigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "rocher")
        {
            hj.enabled = true;
            rb.bodyType = RigidbodyType2D.Dynamic;      //  Dynamicに切り替え
        }
    }
}
