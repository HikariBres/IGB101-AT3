using UnityEngine;

public class doorTriggerScript : MonoBehaviour
{
    public bool openDoorBool = false;
    void OnTriggerEnter(Collider other)
    {
        CharacterController cc = other.GetComponent<CharacterController>();
        if (cc){
            openDoorBool = true;
        }
    }
}
