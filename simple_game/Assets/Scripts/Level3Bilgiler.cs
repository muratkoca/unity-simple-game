using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Bilgiler : MonoBehaviour {
    public GameObject level;
    public GameObject levelgecis1;
    public GameObject levelgecis2;
    public GameObject levelgecis3;
    public GameObject levelgecis4;
    public GameObject cember;
    public GameObject cember1;
    public GameObject cember2;
    public GameObject cember3;
    public GameObject kup4;
    public Light isik;
    Vector3 yeniKupBoyut;
    Rigidbody yeniKupRigid;
    private void Start()
    {
        level.transform.GetComponent<Renderer>().enabled = false;
        levelgecis1.transform.GetComponent<Renderer>().enabled = false;
        levelgecis2.transform.GetComponent<Renderer>().enabled = false;
        levelgecis3.transform.GetComponent<Renderer>().enabled = false;
        levelgecis4.transform.GetComponent<Renderer>().enabled = false;
    }
    void Update () {
        Kontrol();
    }
    public void Kontrol(){
        if (cember.GetComponent<Renderer>().material.color == Color.black && cember1.GetComponent<Renderer>().material.color == Color.black && cember2.GetComponent<Renderer>().material.color == Color.black && cember3.GetComponent<Renderer>().material.color == Color.black){
            isik.transform.GetComponent<Light>().enabled = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                YeniOlustur();
            }
        }
    }
    public void YeniOlustur()
    {
        GameObject yeni = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        yeni.transform.position = new Vector3(Random.Range(-9f, 9f), 0.784f, Random.Range(-9f, 9f));
        yeniKupBoyut.x = 0.56902f;
        yeniKupBoyut.y = 0.56902f;
        yeniKupBoyut.z = 0.56902f;
        yeni.transform.localScale = yeniKupBoyut;
        yeniKupRigid = yeni.AddComponent<Rigidbody>();
    }
}
