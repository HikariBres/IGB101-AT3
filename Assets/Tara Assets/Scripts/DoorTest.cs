using UnityEngine;

public class DoorTest: MonoBehaviour
{
    Animation dooranimation;
    // Use this for initialization
    void Start()
    {
        dooranimation = GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            dooranimation.Play();
    }
}
