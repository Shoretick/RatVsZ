using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuvevenenosa : MonoBehaviour
{
 public float V = 0.2f;
 public bool damage=false;

    // Start is called before the first frame update
    public void OnTriggerStay(Collider other)
 {
   if (other.tag == "Player")
   {
     other.GetComponent<caminar>().vida -= V;
     damage=true;
    // gameObject.GetComponent<MeshRenderer>().material.SetColor("color",Color.red);
       Destroy(gameObject,3);
      
   }

}
public void OnTriggerExit(Collider other)
{
damage=false;

}


 public void damagecolor()
{ 
    if (damage==true)
    {
     GetComponent<MeshRenderer>().material.SetColor("color",Color.red);
    }


}
}