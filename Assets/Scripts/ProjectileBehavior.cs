using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private Rigidbody projectileRb;
    private GameObject ringInstance;
    public GameObject ring;
    public float launchForce;

    void Start()
    {
        Vector3 target = new Vector3(transform.position.x - 24f, -0.05f, transform.position.z);
        projectileRb = GetComponent<Rigidbody>();
        projectileRb.AddForce(transform.up * launchForce, ForceMode.Impulse);
        ringInstance = Instantiate(ring, target, new Quaternion());
    }

    void Update()
    {
        transform.Rotate(new Vector3(7, 0, 0));

        if (transform.position.y < 1)
        {
            Destroy(gameObject);
            Destroy(ringInstance);
        }
    }
}
