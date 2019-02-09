using System.Collections;
using UnityEngine;
using GoogleARCore.Examples.HelloAR;

public class ButtonController : MonoBehaviour
{
    public GameObject timeSlider;
    public GameObject sizeSlider;

    bool tAn = false;
    bool zAn = false;
    public static bool infoAn = false;

    void Start()
    {
        // beide Slider werden zu Begin deaktiviert
        timeSlider.SetActive(false);
        sizeSlider.SetActive(false);
    }

    // diese Funktion wird ausgeführt wenn der Benutzer auf dem Knopf in der App drückt
    public void TimeChange()
    {
        // wenn der Slider nicht aktiv ist
        if (tAn == false)
        {
            // Zeit Slider wird aktiviert
            timeSlider.SetActive(true);
            tAn = true;
            if (zAn == true)
            {
                // Falls der andere Slider aktiv ist, wird er abgeschalten
                sizeSlider.SetActive(false);
                zAn = false;
            }
        }
        // wenn der Slider bereits aktiviert ist, wird er ausgeschalten
        else if (tAn == true)
        {
            timeSlider.SetActive(false);
            tAn = false;
        }
        
    }

    // dasselbe wie Zeit nur mit dem größeSlider stattdessen
    public void ZoomChange()
    {
        if(zAn == false)
        {
            sizeSlider.SetActive(true);
            zAn = true;
            if (tAn == true)
            {
                timeSlider.SetActive(false);
                tAn = false;
            }
        }        
        else if (zAn == true)
        {
            sizeSlider.SetActive(false);
            zAn = false;
        }
    }

    // bringt Information zum vorscheinen
    public void Info()
    {
        if (infoAn == false)
        {
            infoAn = true;
        }
        else
        {
            infoAn = false;
        }

    }

    // das Sonnensystem wird züruckgesetzt, damit ein neues instanziiert werden kann
    public void Delete()
    {
        GameObject System = GameObject.FindGameObjectWithTag("Sonnensystem");
        HelloARController.hervorgebracht = false;
        Planetenselektion.selektiert = false;
        Planetenbewegung.an = true;
        Destroy(System);
    }
}
