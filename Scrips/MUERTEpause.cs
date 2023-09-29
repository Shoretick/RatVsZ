using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MUERTEpause : MonoBehaviour
{
    bool active;
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = true;
        active= canvas.enabled ;
        Gamecontroller.gamecontroller.points=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
         // StartCoroutine(Example());
          //Example(); 
           
               
           
           
        
    }
      public void bottonpause()
      {
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
    }

    public void bottoncontinuar()
    {
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
    }

    public void Menuppal()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
}IEnumerator Example()
    {
       
        print(Time.time);
        yield return new WaitForSecondsRealtime(70);
        Time.timeScale = (active) ? 0 : 1f;
      
    
        
    }


}
