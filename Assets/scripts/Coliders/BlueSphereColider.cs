using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlueSphereColider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj){ 
        // Nivel 1
        if(obj.gameObject.tag == "enlace"){ 
            SceneManager.LoadScene("Blue_Level_2");
        } 
        // Nivel 2
        if(obj.gameObject.tag == "enlace2"){ 
            SceneManager.LoadScene("Win");
        } 
        else {
            
        }
    }
}
