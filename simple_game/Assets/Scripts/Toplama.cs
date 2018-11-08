using UnityEngine;
public class Toplama : MonoBehaviour {
    public GameObject gidici;
    public GameObject kalici;
    GameObject yeniOlusanKup;
    Vector3 deneme;
    Vector3 eski;
    Vector3 yeni;
    Vector3 yerDegis;
    public void Update()
    {
        Kontrol();
    }
    public void Kontrol()
    {
        float zaman = Time.time;
        string saniye = (zaman % 60).ToString("0");
        float modKontrol = int.Parse(saniye);
        if (modKontrol % 4 == 0)
        {
            //print(modKontrol);
            print(eski.z+"+");
            print(yeni.z);
            if (eski.z == yeni.z)
            {
                print("degerler degişmedi"); 
            }
            if (eski.z !=yeni.z)
            {
                print("degerler degişti");
            }
        }
    }
    public void OnTriggerEnter(Collider obje)
    {
        deneme = obje.transform.localScale;
        eski = obje.transform.localScale;

        deneme.z += gameObject.transform.localScale.z;

        obje.transform.localScale = deneme;

        yeni = obje.transform.localScale;
        yerDegis = gameObject.transform.position;
        yerDegis.x = Random.Range(-8.0f, 10.0f);
        yerDegis.z = Random.Range(-10.0f, 7.0f);
        gameObject.transform.position = yerDegis;
    }
    public void OnTriggerStay(Collider obje)
    {
      //  Debug.Log("Obje alindii");
    }
    public void OnTriggerExit(Collider obje)
    {
     //  Debug.Log("Obje alindiiii");
    }
}
