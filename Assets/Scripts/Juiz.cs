using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Juiz : MonoBehaviour {

    public static int pontosP1, pontosP2, defesaP1, defesaP2 = 0;
    public Text ptsP1, ptsP2;

    public static bool jogando;

	void Start () {
        ptsP1.text = "0";
        ptsP2.text = "0";
        jogando = false;

        StartCoroutine(IniciarJogo());

    }
	
	// Update is called once per frame
	void Update () {

       // Debug.Log("jogador 1 = " + pontosP1);
       // Debug.Log("jogador 2 = " + pontosP2);
        Placar();

    }

    void Placar()
    {
        ptsP1.text = pontosP1.ToString();
        ptsP2.text = pontosP2.ToString();
    }

    IEnumerator IniciarJogo()
    {
        yield return new WaitForSeconds(1.5f);
        jogando = true;
    }


}
