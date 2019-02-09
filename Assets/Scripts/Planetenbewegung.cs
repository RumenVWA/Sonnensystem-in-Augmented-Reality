using UnityEngine;
using System.Collections;

public class Planetenbewegung : MonoBehaviour
{
    // float ist in der Programmierwelt eine Gleitkommazahl
    float t;
    float radiusX, radiusY, radiusZ;

    // die Umlaufzeit der Planeten wird manuell zu den individuellen Planeten im Editor zugeordnet
    public float umlaufzeit;

    public static bool an = true;

    // Transform beinhaltet die Koordinaten und Größe eines Objektes
    public Transform Sonne;
    public Transform Skalierungsfaktor;

    // Awake() wird nur einmal zu Beginn der App ausgeführt
    void Awake()
    {
        // Der Betrag des Radius/Abstands zwischen Sonne und Planet wird berechnet
        radiusX = Mathf.Abs(Sonne.position.x - this.transform.position.x);
        radiusY = Mathf.Abs(Sonne.position.y - this.transform.position.y);
        radiusZ = Mathf.Abs(Sonne.position.z - this.transform.position.z);

        // sorgt für dafür, dass ein kreisförmiger Orbit gebildet wird
        if (radiusZ > radiusX)
        {
            radiusX = radiusZ;
        }
        if (radiusX > radiusZ)
        {
            radiusZ = radiusX;
        }  
    }

    // Wird mit einer konstanten Rate aktualisiert
    void FixedUpdate()
    {
        if (an == true)
        {
            // die Zeit
            t += Time.deltaTime * umlaufzeit * UIScript.beschleunigung;

            // Die Lage der Planeten wird auf alle drei Achse (x, y, z) berechnet 
            float x = (Mathf.Sin(t) * radiusX * Skalierungsfaktor.localScale.x) + Sonne.position.x;
            float y = (Mathf.Cos(t) * radiusY * Skalierungsfaktor.localScale.y) + Sonne.position.y;
            float z = (Mathf.Cos(t) * radiusZ * Skalierungsfaktor.localScale.z) + Sonne.position.z;

            // Neue Position wird angegeben
            transform.position = new Vector3(x, y, z);
        }
    }
}
