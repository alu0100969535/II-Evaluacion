using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	private RaycastHit vision;
	public float rayLength;
	private GameObject player;
	
    // Start is called before the first frame update
    void Start()
    {
        rayLength = Mathf.Infinity;
		player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {	
		int power = player.GetComponent<Power>().powerValue;
		if(Input.GetKeyDown(KeyCode.Z) && (power > 0)) //Disparo tipo A
		{
			//If raycast hit some collider
			if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength))
			{
				Power p = player.GetComponent<Power>();
				TypeA ta = vision.collider.gameObject.GetComponent<TypeA>();
				if(ta != null){
					ta.HandleShoot(p.powerValue);
				}
				p.changePower(-1); //Quitamos energía al jugador
			}
		}
		else if(Input.GetKeyDown(KeyCode.X)) //Disparo tipo A
		{
			//If raycast hit some collider
			if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength))
			{
				player.GetComponent<Money>().changeMoney(50);
				TypeB tb = vision.collider.gameObject.GetComponent<TypeB>();
				if(tb != null){
					tb.HandleShoot();
				}
				Debug.Log(tb);
			}
		}
    }
}
