using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Ajout de plusieurs variables
    //La première est la vitesse du mouvement
    public float moveSpeed = 5f;

    //La deuxième est une référence au rigidbody et la variable sera comme un moteur qui bouge le personnage
    public Rigidbody2D rb;
    //Lien avec l'animator
    public Animator animator;

    public Camera cam;
    Vector2 mousePos;

    //Lien entre Update et FixedUpdate
    Vector2 movement; //2 pour hozintale et verticale

 

    // Update is called once per frame -> on va y mettre des Input
    void Update()
    {
        //cette fonction va faire que quand on veut aller à droite cela va nous donner 1 et à gauche -1 comme un axe
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Animator
        animator.SetFloat("Horizontal", movement.x); //horizontale = premier paramètre de l'animator
        animator.SetFloat("Vertical", movement.y); //verticale = deuxième paramètre de l'animator
        animator.SetFloat("Speed", movement.sqrMagnitude); //la vitesse = troisième paramètre de l'animator

        //Position de la sourie, savoir où elle est par rapport à la caméra
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    // Marche quasiment comme pour la précedente mais on va y mettre les mouvements
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

  
    }
}
