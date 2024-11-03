using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuController : MonoBehaviour
{
  public void SairJogo(){
    Application.Quit(); 
  }

  public void IniciaJogo(){
    SceneManager.LoadScene(1);
  }
}
