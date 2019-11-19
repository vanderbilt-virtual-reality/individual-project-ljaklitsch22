using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOMB_EXPLOSION : MonoBehaviour
{
    public GameObject bomb;

    public float power = 10.0f; // power of explosion (force)hit 
    public float radius = 5.0f; // radius sphere of explosion
    public float upforce = 1.0f; // 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bomb == enabled)
        {
            Invoke("Detonate", 4);
        }
        
    }

    void Detonate()
    {
        Vector3 explosionPositon = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPositon, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPositon, radius, upforce, ForceMode.Impulse);
            }
        }
    }
}
