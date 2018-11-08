using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapıIsınlaUst : MonoBehaviour
{
    Vector3 isinlan;
    private void OnTriggerEnter(Collider other)
    {
        isinlan = other.transform.position;
        isinlan.x = Random.Range(7f, -9f);
        isinlan.y = 3.88f;
        isinlan.z = Random.Range(8f, -9f);
        other.transform.position = isinlan;
    }
}
