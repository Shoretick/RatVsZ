using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Gamecontroller : MonoBehaviour
{
    
    public static Gamecontroller gamecontroller;
    public int points=0;
    public int ban1=0;
public TextMeshProUGUI pointsText;

    // Start is called before the first frame update
    
    void Awake()
    {
           if (gamecontroller==null)
           {
               gamecontroller=this;
               DontDestroyOnLoad(gameObject);

           }else
           {
               if (true)
               {
                   Destroy(gameObject);
               }
           }



    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ban1==0)
        {

            if (points==3)
            {
               
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ban1++;
            }
                           
            }
            if (ban1==1)
        {

            if (points==9)
            {
               
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ban1++;
            }
                           
            }if (ban1==2)
        {

            if (points==30)
            {
               
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ban1=0;
            }
                           
            }

            pointsText.text = points.ToString();
        }
        
    
    
    public void incrementopoints()
    {
points++;
pointsText.text = points.ToString();

    }
}
