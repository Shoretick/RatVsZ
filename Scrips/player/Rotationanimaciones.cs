using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationanimaciones : MonoBehaviour
{


    public int valorRot;
    public GameObject rotreset;
    public caminar Nroanim;
    // Start is called before the first frame update
    void Start()
    {
       // Nroanim= FindObjectsOfType<caminar>();

    valorRot=Nroanim.rotanim;

        //valorRot=GetComponent<caminar>().animpersonaje;
       
        //valorRot.(controlrotanim);
    }

    // Update is called once per frame
    void Update()
    {
     valorRot=Nroanim.rotanim;

        
        if (valorRot==0)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0,-45,0));
        } else
        {
            if (valorRot==1)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        }
          else
          {
              transform.localRotation = Quaternion.Euler(new Vector3(0,-90,0));
          }  
        }
       /* if (valorRot==1)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
        }
        if (valorRot==2)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0,-90,0));
        }
        if (valorRot==3)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0,-90,0));
        }*/

        
    }
}
