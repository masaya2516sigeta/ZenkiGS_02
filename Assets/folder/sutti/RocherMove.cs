using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocherMove : MonoBehaviour
{
    [SerializeField] private float RocherSpeed;         //岩の速度
    [SerializeField] private float RocherLimitSpeed;          //岩の上限速度
    Rigidbody2D rb;



    private void Update()
    {
        //Debug.Log(GetComponent<Rigidbody2D>().velocity);        //岩の速度表示
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Rocher();       //Rocherの呼び出し
    }
    private void Rocher()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();      //rigidbodyを取得
        //Vector2 rocherforce = new Vector2( RocherSpeed * rb.velocity.x, rb.velocity.y);      //力を設定
        if (rb.velocity.magnitude > RocherLimitSpeed)       //決められた上限を超えたら加速を止める
        {
            rb.velocity = new Vector2(rb.velocity.x /1.1f, rb.velocity.y);
        }

        //rb.AddForce(rocherforce);       //力を加える

    }
    public void suitti()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;      //  Dynamicに切り替え
    }
}
