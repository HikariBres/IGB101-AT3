using UnityEngine;

public class doorOpenScript : MonoBehaviour

{
    public doorTriggerScript doorScript;
    public Animation anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start () {
        doorScript = GameObject.FindGameObjectWithTag("doorTrigger").GetComponent<doorTriggerScript>();
        anim = gameObject.GetComponent<Animation>();
        }

    void update (){
        //if (doorScript.openDoorBool == false){
            //anim.Play("doorOpen");
        //}

    }


    
}
