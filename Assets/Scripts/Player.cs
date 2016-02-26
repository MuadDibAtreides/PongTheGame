using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float velocidade = 10;
    Rigidbody lol;
    

    // public float zMin, zMax;


    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {

        mover();
	
	}

    void mover()
    {
        if (gameObject.tag == "Jogador1")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * velocidade * Time.deltaTime);
            }
           
            else //Gambiarra para parar a raquete quando nenhum btn esta sendo apertado
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }
            
        }

        else if (gameObject.tag == "Jogador2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.back * velocidade * Time.deltaTime);
            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }
        }
    }

}
