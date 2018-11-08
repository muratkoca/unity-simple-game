using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapıIsınlaAlt : MonoBehaviour {
    Vector3 isinlan;
    private void OnTriggerEnter(Collider other)
    {
        isinlan = other.transform.position;
        isinlan.x = Random.Range(16f, 35f);
        isinlan.y = 15.61f;
        isinlan.z = Random.Range(-15f, 3f);
        other.transform.position = isinlan;
    }
}
