using UnityEngine;
using UnityEngine.XR.ARFoundation;
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
            Debug.Log(trackedImage.name);
        }
    }
}
