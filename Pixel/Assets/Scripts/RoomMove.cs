using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChange;
    public Vector3 playerChange;
    //référence au script CameraController
    private CameraController cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
            //changer le min et le max du script cameraController car ils sont public
            cam.minPosition += cameraChange;
            cam.maxPosition += cameraChange;
            //bouger le personnage
            collision.transform.position += playerChange;
        }
    }
}
