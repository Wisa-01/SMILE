using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //slider
    [Range(0, 100)]
    //Damage
    public int bulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Faire la meme qui PlayerHit
        if (collision.TryGetComponent(out IDamageable damageable))
        {
                    //Quand un object a le script pot alors elle appelle smash sur le script pot
            //Unifie tout ce qui prend des dégats
            damageable.TakeDamage(bulletDamage);
        }

    }
}
