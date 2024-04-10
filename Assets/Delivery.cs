using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    [SerializeField] Color32 hasPackageColor = new Color32 (255, 255, 255, 1);
    [SerializeField] Color32 hasnoPackageColor = new Color32 (255, 255, 255, 1);
    [SerializeField] float speedDestroy;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Touched");    
    }
     void OnTriggerEnter2D(Collider2D Object) 
    {   
        if(Object.tag == "Package" && hasPackage == false){
            Destroy(Object.gameObject, speedDestroy);
            Debug.Log("Package picked up");
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;
        }
        if(Object.tag == "Customer" && hasPackage){
            Debug.Log("Package delivered");
            spriteRenderer.color = hasnoPackageColor;
            hasPackage = false;

        }
    }
    

}
