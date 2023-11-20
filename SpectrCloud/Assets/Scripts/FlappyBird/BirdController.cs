using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] public Rigidbody rb;

    public void Flap()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up*force);
        Debug.Log("Flap");
    } 

}
