using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Gecis : MonoBehaviour {
    [SerializeField] private string Samp4;
    private void OnTriggerEnter(Collider other)
    {
        Samp4 = "Samp4";
        SceneManager.LoadScene(Samp4);
    }
}
