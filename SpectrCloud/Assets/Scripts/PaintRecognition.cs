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
                    SceneManager.LoadScene(1);
                break;
                case "Paint2":
                    SceneManager.LoadScene(2);
                break;
                case "Paint3":
                    SceneManager.LoadScene(3);
                break;
                case "Paint7":
                    SceneManager.LoadScene(7);
                break;
                case "Paint5":
                    SceneManager.LoadScene(5);
                break;
                case "Paint6":
                    SceneManager.LoadScene(6);
                break;
                
            }
        }

    }
    
}
