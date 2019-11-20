using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_push : MonoBehaviour
{
    public GameObject bomb;

	[SerializeField]
	private Transform spawnPoint;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

    
    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "BUTTON")
		{
			Instantiate(bomb, new Vector3(0,0,0), Quaternion.identity);
		}
	}
}
