using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Cemberler : MonoBehaviour {
    public int i = 0;
    private void OnTriggerExit(Collider other)
    {
        i += 1;
        if (i>=1)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.black);
            print("çember "+other.name+ "tamamlandı!");
            gameObject.GetComponent<Collider>().isTrigger = false;
        }
    }
}
