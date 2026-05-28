using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ronan;

namespace Ronan
{
    public class PlayerMovement : MonoBehaviour
    {

        public Animator anim;

        public float rotSpeed = 10;
        public float up_velocity = 0;

        // Start is called before the first frame update
        void Start()
        {
            TryGetComponent(out anim);
        }

        // Update is called once per frame
        void Update()
        {

            ForwardMovement();

            Turning();

            Jump();

            Actions();

        }

        private void ForwardMovement()
        {
            if (Input.GetKey("w"))
            {
                anim.SetBool("Walking", true);
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    anim.SetBool("Running", true);
                }
                else
                {
                    anim.SetBool("Running", false);
                }
            }
            else if (Input.GetKeyUp("w"))
            {
                anim.SetBool("Walking", false);
                anim.SetBool("Running", false);
            }
        }

        private void Turning()
        {
            if (Input.GetKey("a"))
            {
                transform.Rotate(0, -rotSpeed * 15 * Time.deltaTime, 0, Space.World);
                anim.SetBool("Turn Left", true);
            }
            else if (Input.GetKey("d"))
            {
                transform.Rotate(0, rotSpeed * 15 * Time.deltaTime, 0, Space.World);
                anim.SetBool("Turn Right", true);
            }
            else
            {
                anim.SetBool("Turn Left", false);
                anim.SetBool("Turn Right", false);
            }
        }

        private void Jump()
        {
            CharacterController controller = GetComponent<CharacterController>();
            if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
            {
                up_velocity = 10;
                anim.SetBool("Jumping", true);
            }
            if (!controller.isGrounded || up_velocity > 0)
            {
                controller.Move(new Vector3(0, up_velocity * Time.deltaTime, 0));
                up_velocity -= 9.81f * Time.deltaTime;
            }
            else anim.SetBool("Jumping", false);
        }

        private void Actions()
        {
            if (Input.GetKeyDown("e")) anim.SetBool("Waving", true);

            else if (Input.GetKeyUp("e")) anim.SetBool("Waving", false);

            if (Input.GetKeyDown("q")) anim.SetBool("Backflip", true);

            else if (Input.GetKeyUp("q")) anim.SetBool("Backflip", false);

        }
    }
}
