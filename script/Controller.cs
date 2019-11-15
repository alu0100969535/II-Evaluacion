using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controller : MonoBehaviour
{
	public delegate void collisionCheck(GameObject player);
	public event collisionCheck eventHandler;
	public static Controller controladorDeEscena;
	public GameObject Jugador;
	
	
    // Start is called before the first frame update
    void Start()
    {
        Jugador = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {	
    }
	
	void OnCollisionEnter(Collision collider){
		eventHandler(Jugador);
	}
	
	void Awake()
	{
		if(controladorDeEscena == null){
			controladorDeEscena = this;
			DontDestroyOnLoad(this);
		}		
		else if(controladorDeEscena != this){
			Destroy(this);
		}
	}
}
