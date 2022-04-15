using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static float CameraX = 0, CameraY = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(CameraX, CameraY, -10);
    }
}
