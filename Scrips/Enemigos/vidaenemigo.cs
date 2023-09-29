using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaenemigo : MonoBehaviour
{
public float vida;
    public float vidamaxima=100;
    public GameObject muerte;
    public GameObject spawnmuerte;

    public GameObject initialpossenemy;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioSource ZN2audio;
   
    public float V = 0.2f;
    public Slider barravida;
    public GameObject incremento;
   
    
    



    // Start is called before the first frame update
    void Start()
    {
        ZN2audio=GetComponent<AudioSource>();
        //incremento= GetComponent<Gamecontroller>();
        
    }

        // Update is called once per frame
    void Update()

    { 
      //despatras2=despatras1.despatras;
      barravida.value=vida/vidamaxima;
      
        if (vida>vidamaxima){vida = vidamaxima;}
            if (vida<=1)
            {
              
                Destroy(gameObject);
                Instantiate(muerte,spawnmuerte.transform.position,transform.rotation);
               // incremento.SendMessage("incrementopoints");
                Gamecontroller.gamecontroller.points++;
                
            }else
              {if (vida>vidamaxima){vida = vidamaxima;}}


    
    }
    

    // Start is called before the first frame update
    public void OnTriggerStay(Collider other)
 {
   if (other.tag == "Player")
   {
     other.GetComponent<caminar>().vida -= V;
      // Destroy(gameObject,3);
      
   }

}


}
