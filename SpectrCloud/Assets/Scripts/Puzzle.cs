using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Puzzle : MonoBehaviour
{
private Vector3 offset;

    void OnMouseDown()
    {

        offset = gameObject.transform.position; //-
            //Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -59.3986f));
    }

    void OnMouseDrag()
    {
        gameObject.transform.localPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -59.3986f);
        
    }
}
