using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour {
    public GameObject kup4;
    int hiz;
	// Use this for initialization
	void Start () {
        hiz = 5;
	}
	// Update is called once per frame
	void Update () {
        kup4.transform.Translate(hiz * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, hiz * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
