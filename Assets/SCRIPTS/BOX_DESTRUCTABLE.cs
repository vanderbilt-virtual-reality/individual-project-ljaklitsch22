using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOX_DESTRUCTABLE : MonoBehaviour
{
    public GameObject destroyedVersion;

    //change to on collision
    private void OnMouseEnter()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}
