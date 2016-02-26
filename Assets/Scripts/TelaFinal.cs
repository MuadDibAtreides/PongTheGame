using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TelaFinal : MonoBehaviour {

    public Text defesasP1, defesasP2;

	// Use this for initialization
	void Start ()
    {
        defesasP1.text = Juiz.defesaP1.ToString();
        defesasP2.text = Juiz.defesaP2.ToString();
    }

   


}
