using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotationLandscape : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
