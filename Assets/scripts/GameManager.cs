using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    AudioSource Audio_Source;
    

    public AudioClip
            sound_track;

      void Start(){
        Audio_Source = GetComponent<AudioSource>();
        Audio_Source.clip = sound_track;
        Audio_Source.Play();
        
    }
   
    private void Awake()
    {
       
       
    }

    public void loadScene(string sceneToLoad){
        SceneManager.LoadScene(sceneToLoad);
    }

    
}
