using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitti : MonoBehaviour
{
    GameObject rocher;          //  gameobject�ϐ�
    RocherMove script;          //  script�ϐ�
    //GameObject tuta;            //  �c�^�ϐ�
    //tutaManager script2;        //  tutascript�ϐ�
    // Start is called before the first frame update
    void Start()
    {
        rocher = GameObject.Find("rocher");             //  rocher��T��
        script = rocher.GetComponent<RocherMove>();     //  RocherMove��T��
        //tuta = GameObject.Find("tuta2");                //  tuta2��T��
        //script2 = tuta.GetComponent<tutaManager>();     //  tutaManager��T��
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        script.suitti();                //  RocherMove��suitti�֐������s����
        Destroy(this.gameObject);       //  ����
        //script2.tutaRotate();           //  
    }
}
