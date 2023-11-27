using UnityEngine;

public class Rorshah1 : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image image;
    [SerializeField] private Color color;

    public void OnClick()
    {
        image.color = color;
    }
}
