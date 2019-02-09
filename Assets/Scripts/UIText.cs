using System.Collections;
using UnityEngine;

public class UIText : MonoBehaviour
{
    Transform cameraPosition;
    
    private void Start()
    {
        // die Position der Kamera wird erhoben
        cameraPosition = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    void Update()
    {
        // passiert wenn das Sonnensystem aktiv ist und der Nutzer auf dem Info-Button gedrückt hat
        if (Planetenselektion.selektiert == true && ButtonController.infoAn == true)
        {                    
            // Objekt wird aktiviert
            foreach (Transform go in transform)
            {
            go.gameObject.SetActive(true);
            }

            // hat die gleiche Richtung wie die der Kamera
            transform.rotation = Quaternion.Euler(0, cameraPosition.rotation.eulerAngles.y , 0);
        }

        // Objekt wird ausgeschalten
        if (Planetenselektion.selektiert == false || ButtonController.infoAn == false)
        {
            foreach (Transform go in transform)
            {
                go.gameObject.SetActive(false);
            }
        }
    }
}
