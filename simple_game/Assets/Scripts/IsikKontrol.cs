using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsikKontrol : MonoBehaviour {
    public Light isik;
    public void OnTriggerStay(Collider obje)
    {
        if (isik.transform.GetComponent<Light>().enabled)
        {
            isik.transform.GetComponent<Light>().enabled = false;
        }
        else
        {
            isik.transform.GetComponent<Light>().enabled = true;
        }
    }
}
