using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaleKontrol : MonoBehaviour
{
    public GameObject level;
    public GameObject levelgecis1;
    public GameObject levelgecis2;
    public GameObject levelgecis3;
    public GameObject levelgecis4;
    public Light isik;
    public int gol;
    void Start()
    {
        gol = 0;
        level.GetComponent<Collider>().enabled = false;
    }
    private void Update()
    {
        if (gol >= 1)
        {
            level.transform.GetComponent<Collider>().enabled = true;
            levelgecis1.transform.GetComponent<Renderer>().enabled = true;
            levelgecis2.transform.GetComponent<Renderer>().enabled = true;
            levelgecis3.transform.GetComponent<Renderer>().enabled = true;
            levelgecis4.transform.GetComponent<Renderer>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (isik.transform.GetComponent<Light>().enabled)
        {
            gol += 1;
        }
    }
}
