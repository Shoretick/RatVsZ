using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioZ : MonoBehaviour
{
      public AudioClip audio1;
    public AudioClip audio2;
    public AudioSource ZN2audio;
    public float seconds;
    public int ban1=0;
    private atackplayer2 ATKenemy;
    public bool ATKenemy2;
   
   
   
    
    



    // Start is called before the first frame update
    void Start()
    {
        ZN2audio=GetComponent<AudioSource>();
        ATKenemy=GetComponent<atackplayer2>();
        //ATKenemy2=ATKenemy.damageenemy;
    }

    // Update is called once per frame
    void Update()
    {
 
 
            
    {
       /* if (ban1==0)
        {
            
            ZN2audio.clip= audio1;
             ZN2audio.Play();
        
        StartCoroutine(Example());
          Example(); 
         
        }else
        {
            StopCoroutine(Example());
            
            
        }*/

       

         
    }
        
    }
IEnumerator Example()
    {
       
        print(Time.time);
        yield return new WaitForSecondsRealtime(seconds);
        print(Time.time);
        ban1=1;
        yield return new WaitForSecondsRealtime(seconds);
        ban1=0;
      
    
        
    }
    public void OnTriggerEnter( Collider other)
 {
   if (other.tag == "AtackPlayer")
   { 
      ZN2audio.clip= audio2;
    ZN2audio.Play();
     
    

      }else 
      {
         if (ban1==0)
        {
            
            ZN2audio.clip= audio1;
             ZN2audio.Play();
        
        StartCoroutine(Example());
          Example(); 
         
        }else
        {
            StopCoroutine(Example());
            
            
        }
      }


}

}
