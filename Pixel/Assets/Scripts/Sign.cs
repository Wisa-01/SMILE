using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Pour pouvoir accéder à l'UI
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    //Référence pour la bulle de dialogue
    public GameObject dialogBox;
    //Référence pour le text à l'intérieur
    public GameObject dialogText;
    //Référence pour la string, place du dialogue
    public string dialog;
    //Savoir si oui ou non la box doit être active
    public bool dialogActive;

    public Text contenuText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Faire que la bulle apparaisse avec la barre espace
        if (Input.GetKeyDown(KeyCode.Space)  && dialogActive)
        {
            //Si la boxe de dialogue est active alors on veut la déactivé
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            //Sinon on veut qu'elle soit active
            else
            {
                dialogBox.SetActive(true);
                contenuText.text = dialog;
            }
        }
    }

    //Le personnage entre dans la zone
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Dit si le joueur entre dans la zone, à utiliser si besoin
                    //Debug.Log("SMILE dans la zone");
            //Faire que la bulle apparaisse si le joueur entre dans la zone comme quand le message apparaissait
            dialogActive = true;

        }

    }

    //Le personnage sort de la zone
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Dit si le joueur quitte la zone, à utiliser si besoin
                 //Debug.Log("SMILE quitte la zone");
            //Faire que la bulle dispparaisse si le joueur entre dans la zone comme quand le message apparaissait
            dialogActive = false;
            //Désactiver la bulle de dialogue si le joueur sort de la zone
            dialogBox.SetActive(false);
        }
    }

    
}
