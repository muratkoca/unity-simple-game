using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilgiler : MonoBehaviour
{
    public GameObject kup1;
    public GameObject kup2;
    public GameObject kup3;
    public GameObject kup4;
    public GameObject kapi;
    public Light spotIsik;
    Vector3 isinlan;
    Vector3 deneme;
    Vector3 yeni;
    public static Color myColor;
    public float uzaklik;
    public float kapiUzaklik;
    public float dot;
    float hiz;
    void Start()
    {
        hiz = 5f;
    }


    void Update()
    {


        Mesafe();
        DotPro();
        RenkDegis();
        Teleport();
        TakipEt();

        if (uzaklik < 3)
        {
            kup1.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            myColor = Color.blue;
            RenkDegis();
            YeniOlustur();
            }
        else
        {
            kup1.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.black);
            myColor = Color.red;
            RenkDegis();
        }
        //kup1.transform.Translate(hiz * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, hiz * Input.GetAxis("Vertical") * Time.deltaTime);
        kup4.transform.Translate(hiz * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, hiz * Input.GetAxis("Vertical") * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Inst();
            /*if (Time.frameCount - temp > 100){
                temp += 100;
                print("ok");}*/
        }
    }

    public void Mesafe()
    {
        uzaklik = Vector3.Distance(kup1.transform.position, kup2.transform.position);
    }
    public void Teleport(){
        kapiUzaklik = Vector3.Distance(kup1.transform.position, kapi.transform.position);
        if(kapiUzaklik<2){
            isinlan = kup1.transform.position;
            isinlan.x -= 5f;
            kup1.transform.position = isinlan;
        }
    }

    public void DotPro()
    {
        dot = Vector3.Dot(kup1.transform.position, kup2.transform.position);
    }
    public void RenkDegis()
    {
        spotIsik.transform.GetComponent<Light>().color = myColor;
        spotIsik.color = myColor;
    }
    public void YeniOlustur(){
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
    }
    public void TakipEt(){
        yeni = kup1.transform.position;
        deneme.x = yeni.x;
        deneme.y = yeni.y;
        deneme.z = yeni.z -1;
        kup3.transform.position = deneme;
    }
    public void Inst(){
        Instantiate(kup1, transform.position, transform.rotation);
    }

   
}
