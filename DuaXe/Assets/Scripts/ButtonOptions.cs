using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOptions : MonoBehaviour
{
   public void PlayGame(){
       SceneManager.LoadScene(2);
   }
   public void CarSelect(){
       SceneManager.LoadScene(1);
   }
   public void MainMenu(){
       SceneManager.LoadScene(0);
   }

   public void Car01(){
       SceneManager.LoadScene(1);
   }
}
