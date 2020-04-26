using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour

{
    
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
        //Si l'objet auquel j'ai touché a le script pot, alors il se casse
        //Il va essayer d'avoir Pot et s'il le trouve, il va le mettre dans la variable pot en bas
        if (collision.TryGetComponent(out Pot pot))
        {
            //collision.GetComponent<Pot>().Smash();
            
        }
    }

}
