using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] int life = 10;
    bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(life);
    }

    // Update is called once per frame
    void Update()
    {
        if (dead) return;
        //n�o precisa dos {}, s� tem uma �nica instru��o. Na d�vida sempre ponha {}


        if (life > 0)
        {
            print("vida: " + life);
            life--;


            //print � especifico da classe MonoBehaviour, herda os atributos e metodos dessa classe!
            //Poderia usar Debug.Log no lugar do print!
            //SerializeField , variavel aparece no inspector permitindo ser mudada sem precisar mudar o script!
        }
        else
        {
            print("Jogador est� morto!");
            dead = true;
        }

        
    }
}
