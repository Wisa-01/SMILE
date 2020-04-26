using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour, IDamageable
{
    [Range(0, 100)]
    public int health;
    float slider = 1f;
    public SpriteRenderer spriteRenderer;
    bool dead = false;
    public float speed;

    public void TakeDamage(int damage)
    {
        //-= -> va soustraire la vie avec les dégats
        health -= damage;
       //Meurt si c'est pus petit ou égal à 0
       //! = ==
        if (health <= 0 && !dead)
        {
            StartCoroutine(Disappear());
            dead = true;
            
        }
    }

    IEnumerator Disappear()
    {
        while (slider > 0f)
        {
            slider -= Time.deltaTime*speed;
            spriteRenderer.material.SetFloat("_Disparition", slider);
            yield return new WaitForEndOfFrame();
        }

        Destroy(gameObject);
        
    }

    
}
