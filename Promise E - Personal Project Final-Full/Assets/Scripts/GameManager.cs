using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

   public TextMeshProUGUI gameOverText;
   public Button restartButton;

   void Start()
   {
     
   }

   public void EndGame()
   {
       Debug.Log("GAME OVER");
       gameOverText.gameObject.SetActive(true);
       restartButton.gameObject.SetActive(true);
   }

   public void NoEndGame()
   {      
       gameOverText.gameObject.SetActive(false);
       restartButton.gameObject.SetActive(false);
   }

   public void RestartGame()
   {
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
}
