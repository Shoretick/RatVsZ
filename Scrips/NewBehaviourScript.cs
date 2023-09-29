using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float _time;

   private float F;
public float Period;
public float AngleZ;
public float AngleY;
public float AngleX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 orbita();
    }



void orbita()
{
_time = _time + Time.deltaTime;
float F = Mathf.Sin(_time / Period);
transform.localRotation = Quaternion.Euler(new Vector3(F *AngleX,F *AngleY,F *AngleZ));
}
}
