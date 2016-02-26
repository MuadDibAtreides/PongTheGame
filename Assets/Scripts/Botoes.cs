using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour {

    public void OnClick()
    {
        Application.LoadLevel("Main");
    }

    public void ClickMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void ClickAgain()
    {
        Application.LoadLevel("Main");
    }
}
