using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggers : MonoBehaviour
{
    public GameObject LevelScript;
    public GameObject PlayerControl;
    [SerializeField] private GameObject WinCanvas;
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        LevelScript.SetActive(false);
        WinCanvas.SetActive(true);
        Destroy(gameObject);
    }
}
