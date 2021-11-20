using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {
   void OnTriggerEnter(Collider other) {
       loadNextScene();
   }

   public void loadNextScene() {
       int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
       SceneManager.LoadScene(currentSceneIndex + 1);
   }

   public void loadStartScene() {
       SceneManager.LoadScene(0);
   }
}
