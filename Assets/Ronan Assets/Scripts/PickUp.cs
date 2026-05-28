using Unity.VisualScripting;
using UnityEngine;

namespace Ronan
{
    public class PickUp : MonoBehaviour
    {
        Ronan.GameManager game_manager;
        public bool is_billboard;

        private void Start()
        {
            game_manager = FindAnyObjectByType(typeof(Ronan.GameManager)).GetComponent<Ronan.GameManager>();
        }

        private void Update()
        {
            if (is_billboard) transform.eulerAngles = Camera.main.transform.eulerAngles;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                game_manager.current_pickups++;
                Destroy(gameObject);
            }
        }
    }
}
