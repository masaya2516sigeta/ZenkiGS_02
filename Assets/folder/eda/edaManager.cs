using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edaManager : MonoBehaviour
{
    Rigidbody2D rb;         //  rigidbody
    bool rotateFlg = false; //  回転フラグ
    [SerializeField]float rotate;   //  回転の強さ
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       //  コンポーネント取得
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateFlg)                          //  rotateFlgがtrueの時実行する
        {
                transform.Rotate(0, 0, rotate);     //  回転させる
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "rocher")                  //  接触したオブジェクトのtagが"rocher"だったら実行する
        {
            rb.bodyType = RigidbodyType2D.Dynamic;      //  Dynamicに切り替え
            rotateFlg = true;                           //  フラグ切り替え

            Destroy(this.gameObject, 1.5f);
        }

    }


}
