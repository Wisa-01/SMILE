using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Ajout de plusieurs variables
    public Transform firepoint; //Références à l'objet FirePoint
    public GameObject bulletPrefab; //Références à la "balle"

    public float bulletForce = 20f; //Pour contrôler la force du tir
    Vector2 mousePos;//direction de la sourie


    // Update is called once per frame
    void Update()
    {
        //Vérifier quand est-ce qu'on veut tirer
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(); //Donc si le bouton est presser, le personnage tire
        }
    }

    

    void Shoot()
    {
        //Trouver la position de la sourie par rapport à la caméra
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Avoir la position de la souris par rapport à la position du perso. -> la direction
        Vector2 lookDir = (mousePos - (Vector2)transform.position).normalized;// normalized = remettre dans le cercle trigo
        //2 choses, la première: apparition de la balle au lieu de tie FirePoint
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //La deuxième : lui appliquer une certaine force
        rb.AddForce(lookDir * bulletForce, ForceMode2D.Impulse);
    }
}
