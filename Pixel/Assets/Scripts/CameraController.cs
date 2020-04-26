using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //variable qui va décider qu'est ce que la caméra va suivre
    public Transform target;
    //référence pour la vitesse à laquelle la caméra va se rendre au target
    public float smoothing;

    //2 nouvelles variables pour que la caméra ne sorte pas du monde, qu'elle s'arrete au bord
    public Vector2 maxPosition;
    public Vector2 minPosition;


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
        if(transform.position != target.position ) //donc si la position de la caméra n'est pas celle du target, elle bouge
            {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            //bloquer le min et le max avec Clamp
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            //lerp -> trouve la distance entre les deux et bouge un certain pourcentage chaque frame
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

            
        }
    }

}
