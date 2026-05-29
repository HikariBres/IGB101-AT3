using UnityEngine;

public class doorOpenScript : MonoBehaviour

{
    public doorTriggerScript doorScript;
    public Animation anim;
    public bool doorOpened = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        doorScript = GameObject.FindGameObjectWithTag("doorTrigger").GetComponent<doorTriggerScript>();
        anim = gameObject.GetComponent<Animation>();
        }
    
    void Update(){
        if(doorScript.openDoorBool == true){
            if(doorOpened == false){
                anim.Play("doorOpen");
                doorOpened = true;
            }
        }
    }

}
