using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAdjuster : MonoBehaviour
{
    // Das Sonnensystem wird zwischen dem Boden und Kamera instanziiert, anstatt direkt am Boden
    void Start()
    {
        Transform cameraPosition = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        float y = (transform.position.y - cameraPosition.transform.position.y) / 2f;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
