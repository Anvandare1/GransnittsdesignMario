using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nivå1 : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadSceneAsync(2);
   }
}
