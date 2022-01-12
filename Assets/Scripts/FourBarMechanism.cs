using UnityEngine;

public class FourBarMechanism : MonoBehaviour
{
    [SerializeField] float forceFactor, dir;   

    private void FixedUpdate()
    {
        FourBarForce();
    }    

    void FourBarForce()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForceAtPosition(rb.mass * transform.up * forceFactor, transform.TransformPoint(Vector3.right * dir));
    }
}
