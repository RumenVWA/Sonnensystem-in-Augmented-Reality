using UnityEngine;
using UnityEngine.UI;
using GoogleARCore.Examples.HelloAR;

public class UIScript : MonoBehaviour
{
    public GameObject Info, Size, Time, Delete;

    public static float faktor;
    public static float beschleunigung;

    Slider sliderGröße, sliderZeit;

    void Awake()
    {
        sliderZeit = GameObject.FindGameObjectWithTag("SliderTime").GetComponent<Slider>();
        sliderGröße = GameObject.FindGameObjectWithTag("SliderSize").GetComponent<Slider>();
    }

    void Update()
    {
        beschleunigung = sliderZeit.value;
        faktor = sliderGröße.value;

        // Alle Elemente warden hervorgebracht wenn das Sonnensystem instanziiert ist
        if (HelloARController.hervorgebracht == true)
        {
            Time.SetActive(true);
            Size.SetActive(true);
            Delete.SetActive(true);
        }
        else if (HelloARController.hervorgebracht == false)
        {
            Time.SetActive(false);
            Size.SetActive(false);
            Delete.SetActive(false);
        }

        // Solang kein Planet selektiert ist bleibt der Info-Button unsichtbar
        if (Planetenselektion.selektiert == false)
        {
            Info.SetActive(false);
            ButtonController.infoAn = false;
        }
        else if (Planetenselektion.selektiert == true)
        {
            Info.SetActive(true);
        }
    }
}
