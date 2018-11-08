using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Kapi : MonoBehaviour {
    Vector3 isinlan;
    private void OnTriggerEnter(Collider other)
    {
        isinlan = other.transform.position;
        isinlan.x = 5f;
        isinlan.y = 1f;
        isinlan.z = 0.32f;
        other.transform.position = isinlan;
    }
}
