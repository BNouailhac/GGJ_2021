using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour {
  void Start() {
  //1
    Application.targetFrameRate = 60;
  }
  //2
  public void GoToGame() {
  //3
    SceneManager.LoadScene("PreIntro");
  }

  public void QuitGame() {
      Debug.Log("QUIT!");
      Application.Quit();
  }
}