using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caminar : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity;
    public Animator animpersonaje;
    public float vida;
    private float vidamaxima=100;
    public GameObject muerte;
    public GameObject spawnmuerte;
    private int ban1=0;
    public int damage1;
    public Slider barravida;
    public int rotanim;
    private float x;
    private float y;
    public Joystick joydigital;
    Rigidbody2D rb;
    void Start()
    {
       //damage1=GetComponent<nuvevenenosa>().damage+=0;
        animpersonaje=GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()

    {
        float movX;
        float movY;
        float joyX;
        float joyY;
        //public float movXt= movX+joyX;
        


        movY=Input.GetAxis("Vertical");
        movX= Input.GetAxis("Horizontal");
        joyX=joydigital.Horizontal;
        joyY=joydigital.Vertical;  


       barravida.value=vida/vidamaxima; //barra de vida

        if (movY+joyY!=0 || movX+joyX!=0)
    { transform.Translate(0,0,movX+joyX*Time.deltaTime*velocity);
    
    transform.Translate(movY+joyY*Time.deltaTime*(-velocity),0,0);
   
  
    animpersonaje.SetInteger("Animpersonaje",1);rotanim=1;}
    else{animpersonaje.SetInteger("Animpersonaje",0);rotanim=0;}
    ///////////////////////////////////////////////////////////
   /*  if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
    { transform.Translate(0,0,Input.GetAxis("Horizontal")*Time.deltaTime*velocity);
    y = (Input.GetAxis("Horizontal")*Time.deltaTime*velocity);
    transform.Translate(Input.GetAxis("Vertical")*Time.deltaTime*(-velocity),0,0);
    x = (Input.GetAxis("Vertical")*Time.deltaTime*(-velocity));
  
    animpersonaje.SetInteger("Animpersonaje",1);rotanim=1;}
    else{animpersonaje.SetInteger("Animpersonaje",0);rotanim=0;}

*/


/////////////////////////////////////////////////////////////////
    if (Input.GetButtonDown("Fire1"))
     { animpersonaje.SetInteger("Animpersonaje",2);rotanim=2;}
     
     if (Input.GetButtonDown("Fire2"))
     { animpersonaje.SetInteger("Animpersonaje",3);rotanim=3;}
        
        
     if (ban1==0)
     {
         if (vida>vidamaxima){vida = vidamaxima;}
            if (vida<=1){Destroy(gameObject);
            Instantiate(muerte,spawnmuerte.transform.position,transform.rotation);
          ban1=1;  }
         
     }else
     {
         if (vida>vidamaxima){vida = vidamaxima;}
     }
    }




    /*public void damagecolor()
{ 
    if (damage1==1)
    {
     GetComponent<MeshRenderer>().material.SetColor("color",Color.red);
    }


}*/

public void fire1()
{
animpersonaje.SetInteger("Animpersonaje",2);rotanim=2;

}
public void fire2()
{
animpersonaje.SetInteger("Animpersonaje",3);rotanim=3;

}


}
