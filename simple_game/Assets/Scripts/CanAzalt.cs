using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanAzalt : MonoBehaviour {
    public GameObject oyuncu;
    Vector3 yerDegis;
    Vector3 canDusur;
    Vector3 yeniKupBoyut;
    public float geriSayim = 2;
    private void Update()
    {
        geriSayim -= Time.deltaTime;
        if (geriSayim <= 0)
        {
            YeniOlustur();
            geriSayim = 2;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            canDusur = oyuncu.gameObject.transform.localScale;
            canDusur.z -= 1;
            oyuncu.gameObject.transform.localScale = canDusur;
         }
    }
    public void YeniOlustur(){
/*        GameObject yeni = Instantiate(canAzalt);//burada kaldım
        yeni.transform.position = new Vector3(Random.Range(-9f, 9f), 0.784f, Random.Range(-9f, 9f));
        yeniKupBoyut.x = 0.56902f;
        yeniKupBoyut.y = 0.56902f;
        yeniKupBoyut.z = 0.56902f;
        yeni.transform.localScale = yeniKupBoyut;*/
    }
}
