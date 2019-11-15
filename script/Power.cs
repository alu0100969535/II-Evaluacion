using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
	public int powerValue;
	public int costOfPower;
	private Money playerMoney;
	
    // Start is called before the first frame update
    void Start()
    {
		powerValue = 5;
		costOfPower = 10;
		playerMoney = GameObject.FindWithTag("Player").GetComponent<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void buyPower(int p)
	{
		int cost = this.costOfPower * p;
		if(playerMoney.currentMoney >= cost){
			playerMoney.changeMoney(-cost);
			this.powerValue += p;
		}
	}
	
	public void changePower(int p)
	{
		this.powerValue += p;
	}
}
