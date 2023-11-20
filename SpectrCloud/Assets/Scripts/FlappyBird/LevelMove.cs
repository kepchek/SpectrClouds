using UnityEngine;

public class LevelMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        this.transform.position -= Vector3.right * _speed * Time.deltaTime;
    }
}
