using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atackplayer2 : MonoBehaviour
{
    // Start is called before the first frame update


public int i;//variable de control
private Collider col;
public int ban1=0;
public GameObject initialposs;//guardo la posicion inicial para resetearla
Vector3 initialposs2;
public GameObject rotation;//guardo la rotacion del padre del objeto
public float damage = 0.2f;
public float alcalce=0.5f;//controlo la distancia en la que quiero que accione el objeto
public GameObject targetEnemy;
public bool enemypunch= false;

private Rigidbody rb;
public float force=1;
public GameObject ataque;
public GameObject apawnataque;
public bool damageenemy= false;


    void Start()
    {
        rb=GetComponent<Rigidbody>();
        targetEnemy = GameObject.FindGameObjectWithTag("Player");
      
    }

    // Update is called once per frame
    void Update()
    {
                
                 rb.AddForce(new Vector3(force,0,0));
              Destroy(gameObject,0.5f);
               
                
                
                
                // OnCollisionEnter();
                
        //OnTriggerExit();
     

        
        //despatras=0;
       
    }

void returnposinicial() //funcion para resetear la posicion del objeto
{
    transform.position= initialposs2;//initialposs.transform.position;
   
     
}
public void OnTriggerEnter( Collider other)
 {
   if (other.tag == "ZombieN")
   { 
       damageenemy= true;
     other.GetComponent<vidaenemigo>().vida -= damage;
    

      }else
      {
          damageenemy= false;
      }


}
/*void OnCollisionEnter() {
    col.isTrigger = true;
   
   
}
void OnTriggerExit() {
    col.isTrigger = false;

}
void colicionenemy(Collider other)
{
  
{
 
}
//targetEnemy.transform.position;

}*/
}
