using System.Collections;
using UnityEngine;

public class Planetenselektion : MonoBehaviour
{
    public GameObject Sonne;
    GameObject[] Planeten;

    Vector3 originaleGröße;

    // eine boolesche Variable kann entweder wahr oder falsch sein
    public static bool selektiert = false;

    void Awake()
    {
        // Die ursprüngliche Größe wird gespeichert
        originaleGröße = transform.localScale;
        // Eine Array/Liste von all den Planeten wird erstellt
        Planeten = GameObject.FindGameObjectsWithTag("Planet");
    }

    // Wenn man auf einem Objekt drückt passiert das
    void OnMouseDown()
    {
        // Jeweils die Funktion Selektieren oder Deselektieren wird ausgeführt
        if (selektiert == false)
        {
            Selektieren();
        }
        else
        {
            Deselektieren();
        }
    }

    void Selektieren()
    {
        // Orbit wid ausgeschalten
        Planetenbewegung.an = false;
        // Der Planet wird im Zentrum der Szene platziert
        transform.position = Sonne.transform.position;
        transform.localScale = Sonne.transform.localScale;
        // sorgt dafür, dass beim nächsten Mal, Deselektieren ausgeführt wird
        selektiert = true;

        // Alle Objekte, außer das Selektierte, werden deaktiviert
        foreach (GameObject planet in Planeten)
        {
            planet.SetActive(false);
            gameObject.SetActive(true);
        }
    }

    public void Deselektieren()
    {
        // das Gegenteil von Selektieren()
        Planetenbewegung.an = true;
        transform.localScale = originaleGröße;
        selektiert = false;

        foreach (GameObject planet in Planeten)
        {
            planet.SetActive(true);
        }
    }
}
