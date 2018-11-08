using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanArttır : MonoBehaviour {
    public  GameObject oyuncu;
    Vector3 yerDegis;
    Vector3 canVer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canVer = oyuncu.gameObject.transform.localScale;
            canVer.z += 1;
            oyuncu.gameObject.transform.localScale = canVer;
        }
    }
}
