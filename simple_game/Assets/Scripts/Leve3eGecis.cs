using UnityEngine;
using UnityEngine.SceneManagement;

public class Leve3eGecis : MonoBehaviour {
    public GameObject levelgecis1;
    public GameObject levelgecis2;
    public GameObject levelgecis3;
    public GameObject levelgecis4;
    public Light isik;
    [SerializeField] private string Samp3;
    void Start () {
        levelgecis1.transform.GetComponent<Renderer>().enabled = false;
        levelgecis2.transform.GetComponent<Renderer>().enabled = false;
        levelgecis3.transform.GetComponent<Renderer>().enabled = false;
        levelgecis4.transform.GetComponent<Renderer>().enabled = false;
    }
	void Update () {
        if (isik.transform.GetComponent<Light>().enabled)
        {
            levelgecis1.transform.GetComponent<Renderer>().enabled = true;
            levelgecis2.transform.GetComponent<Renderer>().enabled = true;
            levelgecis3.transform.GetComponent<Renderer>().enabled = true;
            levelgecis4.transform.GetComponent<Renderer>().enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Samp3);
    }
}
