using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preintro : MonoBehaviour
{
    public void GoToGame() {
    SceneManager.LoadScene("PreIntroTwo");
  }
}
