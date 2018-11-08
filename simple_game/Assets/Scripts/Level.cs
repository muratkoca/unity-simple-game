using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {
    public GameObject levelgecis1;
    public GameObject levelgecis2;
    public GameObject levelgecis3;
    public GameObject levelgecis4;
    public GameObject kup4;
    [SerializeField]private string Samp;
    Vector3 yeni;
    Vector3 kup4Kontol;
    private void Start()
    {
        levelgecis1.transform.GetComponent<Renderer>().enabled = false;
        levelgecis2.transform.GetComponent<Renderer>().enabled = false;
        levelgecis3.transform.GetComponent<Renderer>().enabled = false;
        levelgecis4.transform.GetComponent<Renderer>().enabled = false;
    }
    private void Update()
    {
        kup4Kontol = kup4.transform.localScale;
        if (kup4Kontol.z >3)
        {
            levelgecis1.transform.GetComponent<Renderer>().enabled = true;
            levelgecis2.transform.GetComponent<Renderer>().enabled = true;
            levelgecis3.transform.GetComponent<Renderer>().enabled = true;
            levelgecis4.transform.GetComponent<Renderer>().enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        yeni = other.transform.localScale;
        if (yeni.z > 3 && other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Samp);
        }
    }
}
