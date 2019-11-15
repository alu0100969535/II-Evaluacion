using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeB : MonoBehaviour
{	
	public Renderer rr;
	public Color colorA;
	public Color colorB;
	public float lerp;
	private bool forward;
    // Start is called before the first frame update
    void Start()
    {
		rr = GetComponentInChildren<Renderer>();
		colorA = rr.material.color;
		colorB = Color.black;
        lerp = 0.0f;
		forward = true;
		//Controller.controladorDeEscena.eventHandler += TakePower;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void HandleShoot()
	{
		rr.material.color = Color.Lerp(colorA, colorB, lerp);
		changeLerp();
	}
	
	void changeLerp()
	{
		if(forward)
			lerp += 0.1f;
		else 
			lerp -= 0.1f;
		
		if(lerp < 0.05f)
			forward = true;
		else if( lerp > 0.95f)
			forward = false;
	}
}
