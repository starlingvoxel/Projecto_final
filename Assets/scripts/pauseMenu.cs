using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    public Slider slider;
    public float sliderValue;
    public Slider sliderbrillo;
    public float sliderValuebrillo;
    public Image panelBrillo;
    // Start is called before the first frame update
    void Start(){
        //slider.value = PlayerPrefs.GetFloat("volumenAudio" , 0.5f);
        sliderbrillo.value = PlayerPrefs.GetFloat("brillo" , 0f);
        AudioListener.volume = slider.value;
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderbrillo.value);
    }

    public void ChangeSlider(float valor){
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio" , sliderValue);
        AudioListener.volume = slider.value;
    }
    public void ChangeSliderBrillo(float valor){
        sliderValuebrillo = valor;
        PlayerPrefs.SetFloat("brillo" , sliderValuebrillo);
        AudioListener.volume = slider.value;
         panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderbrillo.value);
    }
  public void Pause(){

      pausemenu.SetActive(true);
      Time.timeScale = 0f;
  }
  public void Resume(){

      pausemenu.SetActive(false);
      Time.timeScale = 1f;
  }
    public void Home(int menu){

        SceneManager.LoadScene(menu);
        Time.timeScale = 1f;

    }
}
