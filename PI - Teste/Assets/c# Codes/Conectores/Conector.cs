using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conector : MonoBehaviour
{
    
        public void LoadScene(string Jogo)
    {
        SceneManager.LoadScene(Jogo);
    }

}
