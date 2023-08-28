using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newgame : MonoBehaviour
{
    public void PlayGame (){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
