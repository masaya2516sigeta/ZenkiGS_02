using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static float CameraX = 0, CameraY = 0;
    public static byte R=130, G=68, B=0;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        
        //camera.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.Camera>().backgroundColor = new Color32(R, G, B, 0);
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(CameraX, CameraY, -10);
    }
}
