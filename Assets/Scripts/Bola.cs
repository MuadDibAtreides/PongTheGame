using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Bola : MonoBehaviour {

    Rigidbody bola;
    int ran, ranY;
    public float LimitePontos = 3;
    public float velocidadeX;
    public float velocidadeY;
    private float velocidadeAUX;
    Vector3 posInicial;
    Vector3 foraDeJogo = new Vector3(100.0f, 100.0f, 100.0f);
    

    // Use this for initialization
    void Start ()
    {
        velocidadeAUX = velocidadeX;

        random();
               
        bola = GetComponent<Rigidbody>();

        posInicial = transform.position;     
	
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(ran);
        if (Juiz.jogando)
        {
            MoverBola();
        }

        Debug.Log(Juiz.defesaP1);
        TerminarJogo();
    }


    void MoverBola()
    {
        // bola.AddForce(transform.right * velocidade * -1);
        // velocidadeX *= ran;
        //  velocidadeY *= ran;

        bola.velocity = new Vector3(velocidadeX * ran, 0.0f, (velocidadeY + ranY) * ran);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.tag == "Jogador1" || collision.rigidbody.tag == "Jogador2")
        {
            InverterX(); //rebatendo... *-1

            if (collision.rigidbody.tag == "Jogador1")
            {
                Juiz.defesaP1++;
            }
            else
                Juiz.defesaP2++;
        }

        else if (collision.rigidbody.tag == "Borda")
        {
            InverterY();
        }

        else if (collision.rigidbody.tag == "GolP1")
        {

            Juiz.pontosP2 = Juiz.pontosP2 + 1;
            

            transform.position = foraDeJogo;

          //  random();

            StartCoroutine(JogarBola());
           
        }

        else if (collision.rigidbody.tag == "GolP2")
        {
            Juiz.pontosP1 = Juiz.pontosP1 + 1;

           transform.position = foraDeJogo;

           // random();

            StartCoroutine(JogarBola());
             
        }
   
    }

    void InverterX()
    {
        if (velocidadeX <= 18.0f && velocidadeX >= -18.0f)
        {
            velocidadeX = velocidadeX * 1.1f;
        }
        velocidadeX *= -1;
       // velocidadeX += 4.9f;
        
    }

    void InverterY()
    {
        velocidadeY = (velocidadeY + 2.0f) * -1;
    }
    //metodo para decidir para que lado a bola vai ser lancada no inicio
    void random()
    {
        ran = Random.Range(-1, 2);

        while (ran == 0)
        {
            ran = Random.Range(-1, 2);
        }

        ranY = Random.Range(1, 4);
    }

    IEnumerator JogarBola()
    {
        yield return new WaitForSeconds(3.0f);

        velocidadeX = velocidadeAUX;

        transform.position = posInicial;

        random();
    }

    void TerminarJogo()
    {
        if (Juiz.pontosP1 == LimitePontos || Juiz.pontosP2 == LimitePontos)
        {
            Juiz.jogando = false;
            Application.LoadLevel("Final");
            Juiz.pontosP1 = Juiz.pontosP2 = 0;
        }
    }




}
