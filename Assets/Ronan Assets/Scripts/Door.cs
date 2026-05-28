using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open;
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        open = false;
        TryGetComponent(out anim);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 player_position = GameObject.FindGameObjectWithTag("Player").transform.position;
            if (Vector3.Magnitude(player_position - transform.position) < 12)
            {
                open = !open;
                anim.SetBool("Opened", open);
            }
        }
    }
}
