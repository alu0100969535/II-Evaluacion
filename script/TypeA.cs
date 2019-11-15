using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeA : MonoBehaviour
{
	//public Controller controller;
	
    // Start is called before the first frame update
    void Start()
    {
        //Controller.controladorDeEscena.eventHandler += GivePower;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void HandleShoot(int force)
	{
		float s = force / -50.0f;
		transform.localScale += new Vector3(s, s, s);
	}
}
