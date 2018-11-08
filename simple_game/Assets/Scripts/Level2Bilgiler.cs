using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Bilgiler : MonoBehaviour {
    public GameObject kapiAlt;
    public GameObject oyuncu;
    public GameObject levelgecis1;
    public GameObject levelgecis2;
    public GameObject levelgecis3;
    public GameObject levelgecis4;
    public Light isik;
    Vector3 atama;
	// Use this for initialization
	void Start () {
        isik.transform.GetComponent<Light>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        atama = oyuncu.transform.localScale;
        gizle();
        if (atama.z >= 3)
        {
            kapiAlt.GetComponent<Renderer>().enabled = true;
            kapiAlt.GetComponent<Collider>().enabled = true;
            if (isik.transform.GetComponent<Light>().enabled)
            {
                goster();
            }
        }
    }
    public void gizle(){
        kapiAlt.GetComponent<Renderer>().enabled = false;
        kapiAlt.GetComponent<Collider>().enabled = false;
        levelgecis1.GetComponent<Renderer>().enabled = false;
        levelgecis1.GetComponent<Collider>().enabled = false;
        levelgecis2.GetComponent<Renderer>().enabled = false;
        levelgecis2.GetComponent<Collider>().enabled = false;
        levelgecis3.GetComponent<Renderer>().enabled = false;
        levelgecis3.GetComponent<Collider>().enabled = false;
        levelgecis4.GetComponent<Renderer>().enabled = false;
        levelgecis4.GetComponent<Collider>().enabled = false;
    }
    public void goster(){
        levelgecis1.GetComponent<Renderer>().enabled = true;
        levelgecis1.GetComponent<Collider>().enabled = true;
        levelgecis2.GetComponent<Renderer>().enabled = true;
        levelgecis2.GetComponent<Collider>().enabled = true;
        levelgecis3.GetComponent<Renderer>().enabled = true;
        levelgecis3.GetComponent<Collider>().enabled = true;
        levelgecis4.GetComponent<Renderer>().enabled = true;
        levelgecis4.GetComponent<Collider>().enabled = true;
    }
}
