using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float force;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3 (h, 0.5f, v);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(vector * force * Time.deltaTime);   
    }

    void OnTriggerEnter(Collider obj){
        // Select Color
        if(obj.gameObject.tag == "tag_yellow"){ 
            SceneManager.LoadScene("Yellow_Level_1");
        } 
        if(obj.gameObject.tag == "tag_red"){ 
            SceneManager.LoadScene("Red_Level_1");
        } 
        if(obj.gameObject.tag == "tag_green"){ 
            SceneManager.LoadScene("Green_Level_1");
        } 
        if(obj.gameObject.tag == "tag_blue"){ 
            SceneManager.LoadScene("Blue_Level_1");
        } 
        if(obj.gameObject.tag == "tag_purple"){ 
            SceneManager.LoadScene("Purple_Level_1");
        } 
        else {
            
        }
    }
}