using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscene1 : MonoBehaviour
{

    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public AudioSource scene1;
    public int aleatorio;
    // Start is called before the first frame update
    void Start()
    {
        scene1=GetComponent<AudioSource>();
        aleatorio= Random.Range(1,5);
        musica();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void musica()
    {
        if (aleatorio==1)
    {
        scene1.clip= audio1;
        scene1.Play();
    }
    if (aleatorio==2)
    {
        scene1.clip= audio2;
        scene1.Play();
    }
    if (aleatorio==3)
    {
        scene1.clip= audio3;
        scene1.Play();
    }
    if (aleatorio==4)
    {
        scene1.clip= audio4;
        scene1.Play();
    
    }
    }
     
}
