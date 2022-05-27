using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutaManager : MonoBehaviour
{
    HingeJoint2D hj;        //  HingeJoint�p�ϐ�
    Rigidbody2D rb;         //  Rigidbody�p�ϐ�
    // Start is called before the first frame update
    void Start()
    {
        hj = GetComponent<HingeJoint2D>();      //  hingejoint���擾
        rb = GetComponent<Rigidbody2D>();       //  rigidbody���擾
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
            rb.bodyType = RigidbodyType2D.Dynamic;      //  Dynamic�ɐ؂�ւ�
        }
    }
}
