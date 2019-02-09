using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Skalierung : MonoBehaviour
{
    float x,y,z;

    void Start()
    {
        // Sonnensystem wird kleiner gemacht
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // ursprüngliche Koordinaten werden gespeichert
        x = transform.localScale.x;
        y = transform.localScale.y;
        z = transform.localScale.z;
    }

    void Update()
    {
        // der neue Wert wird angewendet
        transform.localScale = new Vector3(x * UIScript.faktor, y * UIScript.faktor, z * UIScript.faktor);      
    }

}
