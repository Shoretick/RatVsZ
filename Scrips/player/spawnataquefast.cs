using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnataquefast : MonoBehaviour
{
    public GameObject ataque;
public GameObject apawnataque;
public float ban1=0;
public float time;
public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetButtonDown("Fire2"))
        {
            if (ban1==0)
            {
                //Instantiate(ataque,apawnataque.transform.position,transform.rotation);
               StartCoroutine(Example());
                Example(); 
            ban1=1;
            
            }
            if (ban1==1)
            {
                //StartCoroutine(Example());
                //Example();
                StopCoroutine(Example());
            }
        }
    }  
    IEnumerator Example()
    {
        ban1=0;
        Instantiate(ataque,apawnataque.transform.position,transform.rotation);
        print(Time.time);
        yield return new WaitForSecondsRealtime(seconds);
        print(Time.time);
        ban1=0;
        Instantiate(ataque,apawnataque.transform.position,transform.rotation);
    }  
}
