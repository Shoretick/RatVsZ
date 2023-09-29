using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curarcruzverde : MonoBehaviour
{
 public float V = 0.2f;
 //public bool damage=false;

    // Start is called before the first frame update
    public void OnTriggerStay(Collider other)
 {
   if (other.tag == "Player")
   {
     other.GetComponent<caminar>().vida += V;
     //damage=true;
      Destroy(gameObject,3);
         
    }

}
public void OnTriggerExit(Collider other)
{
//damage=false;

}

}
