using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
	public int currentMoney;
    // Start is called before the first frame update
    void Start()
    {
        currentMoney = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void changeMoney(int m)
	{
		currentMoney += m;
	}
}
