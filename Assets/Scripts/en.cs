using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en : MonoBehaviour
{
    static public bool WhiteCheck = false;
    SpriteRenderer Sr; //コンポーネント取得
    // Start is called before the first frame update
    void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            WhiteCheck = true;
            Sr.color = new Color(255/255, 100/255, 130/255,0.5f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block"|| collision.gameObject.tag == "Jump")
        {
            WhiteCheck = false;
            Sr.color = new Color(255/255, 255/255, 255/255,0.5f);
        }
    }
}
