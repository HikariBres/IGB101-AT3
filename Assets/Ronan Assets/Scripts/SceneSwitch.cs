using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ronan
{
    public class SceneSwitch : MonoBehaviour
    {
        public string next_level;
        GameManager game_manager;

        private void Start()
        {
            game_manager = FindAnyObjectByType(typeof(GameManager)).GetComponent<GameManager>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && game_manager.level_complete)
            {
                SceneManager.LoadScene(next_level);
            }
        }
    }
}
