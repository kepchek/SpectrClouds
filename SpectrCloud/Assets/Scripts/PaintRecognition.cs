using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;
public class PaintRecognition : MonoBehaviour
{
    private ARTrackedImageManager arTrackedImageManager1;

    private void Awake()
    {
        arTrackedImageManager1 = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        arTrackedImageManager1.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        arTrackedImageManager1.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.referenceImage.name);
            switch(trackedImage.referenceImage.name)
            {
                case "Paint1":
                    SceneManager.LoadScene("Rorshah1");
                break;
                case "Paint2":
                    SceneManager.LoadScene("Paint2");
                break;
                case "Paint4":
                    SceneManager.LoadScene("Paint4");
                break;
                case "Paint5":
                    SceneManager.LoadScene("Gif5");
                break;
                case "Paint6":
                    SceneManager.LoadScene("Puzzle6");
                break;
                case "Paint7":
                    SceneManager.LoadScene("Gif7");
                break;
                case "Paint8":
                    SceneManager.LoadScene("Gif8");
                break;
                case "Paint9":
                    SceneManager.LoadScene("FlappyBird9");
                break;
                case "Paint10":
                    SceneManager.LoadScene("Gif10");
                break;

                
            }
        }

    }
    
}
