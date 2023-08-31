using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class conectorDeCena1 : MonoBehaviour
{

    public void LoadSceneOnClick(string Jogo)
    {
        SceneManager.LoadScene(Jogo);
    }
    
}
