using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suitti : MonoBehaviour
{
    GameObject rocher;          //  gameobject•Ï”
    RocherMove script;          //  script•Ï”
    //GameObject tuta;            //  ƒcƒ^•Ï”
    //tutaManager script2;        //  tutascript•Ï”
    // Start is called before the first frame update
    void Start()
    {
        rocher = GameObject.Find("rocher");             //  rocher‚ğ’T‚·
        script = rocher.GetComponent<RocherMove>();     //  RocherMove‚ğ’T‚·
        //tuta = GameObject.Find("tuta2");                //  tuta2‚ğ’T‚·
        //script2 = tuta.GetComponent<tutaManager>();     //  tutaManager‚ğ’T‚·
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        script.suitti();                //  RocherMove‚ÌsuittiŠÖ”‚ğÀs‚·‚é
        Destroy(this.gameObject);       //  Á‚·
        //script2.tutaRotate();           //  
    }
}
