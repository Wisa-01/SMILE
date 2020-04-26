using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour, IDamageable
{
    //Référence pour l'animator
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        //Completer la référence pour l'animator
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void TakeDamage(int damage)
    {
        anim.SetBool("smash", true);
        
    }
    //Le faire se détruire à la fin de l'animation
    public void Disappear()
    {
        Destroy(gameObject);
    }

}
