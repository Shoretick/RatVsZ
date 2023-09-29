using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atackplayer : MonoBehaviour
{
    // Start is called before the first frame update


public int i;//variable de control
public int ban1=0;
public GameObject initialposs;//guardo la posicion inicial para resetearla
Vector3 initialposs2;
public GameObject rotation;//guardo la rotacion del padre del objeto
public float damage = 0.2f;
private Collider col;
public float alcalce=0.5f;//controlo la distancia en la que quiero que accione el objeto
public GameObject targetEnemy;
public bool enemypunch= false;

public GameObject ataque;
public GameObject apawnataque;
private Rigidbody rb;
public float force=1;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        targetEnemy = GameObject.FindGameObjectWithTag("Player");
      
    }

    // Update is called once per frame
    void Update()
    {
        initialposs2= new Vector3(rotation.transform.position.x, 3+rotation.transform.position.y, rotation.transform.position.z);
        if (Input.GetButtonDown("Fire1"))
        {
            if (ban1==0)
            {
                 rb.AddForce(new Vector3(force,0,0));
            ban1=1;
            Destroy(gameObject,0.5f);
            }else
            {
                returnposinicial();
                ban1=0;
            }
             OnCollisionEnter();
               
                 ban1=0;
        
         
        i = 0;
        }else
        {   //returnposinicial();
        OnTriggerExit();}
        if (ban1==0)
        {
            Instantiate(ataque,apawnataque.transform.position,transform.rotation);
        }
    }





void returnposinicial() //funcion para resetear la posicion del objeto
{
    transform.position= initialposs2;//initialposs.transform.position;
   
     
}
public void OnTriggerEnter( Collider other)
 {
   if (other.tag == "ZombieN")
   {
     other.GetComponent<vidaenemigo>().vida -= damage;
     returnposinicial();
     
   
      
   }
   if (other.tag == "terrain")
     {
         returnposinicial();
     }

}
void OnCollisionEnter() {
    col.isTrigger = true;
   
   
}
void OnTriggerExit() {
    col.isTrigger = false;

}
void colicionenemy(Collider other)
{
    if (other.tag == "ZombieN")
{
 
}
//targetEnemy.transform.position;

}
}
