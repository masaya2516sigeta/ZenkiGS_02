using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitti : MonoBehaviour
{
    GameObject rocher;          //  gameobject変数
    RocherMove script;          //  script変数
    //GameObject tuta;            //  ツタ変数
    //tutaManager script2;        //  tutascript変数
    // Start is called before the first frame update
    void Start()
    {
        rocher = GameObject.Find("rocher");             //  rocherを探す
        script = rocher.GetComponent<RocherMove>();     //  RocherMoveを探す
        //tuta = GameObject.Find("tuta2");                //  tuta2を探す
        //script2 = tuta.GetComponent<tutaManager>();     //  tutaManagerを探す
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        script.suitti();                //  RocherMoveのsuitti関数を実行する
        Destroy(this.gameObject);       //  消す
        //script2.tutaRotate();           //  
    }
}
