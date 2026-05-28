using UnityEngine;
using UnityEngine.UI;
using Ronan;

namespace Ronan
{
    public class GameManager : MonoBehaviour
    {
        public GameObject player;
        public int current_pickups;
        public int max_pickups;
        public bool level_complete = false;

        public Text pickups_text;

        public AudioSource[] audio_sources;
        public float audio_proximity = 20f;


        private void Start()
        {
            max_pickups = FindObjectsByType(typeof(PickUp)).Length;
            audio_sources = FindObjectsByType(typeof(AudioSource)) as AudioSource[];
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            level_complete = LevelComplete();
            pickups_text.text = current_pickups + " of " + max_pickups;

            ControlAudio();
        }

        private bool LevelComplete()
        {
            return current_pickups >= max_pickups;
        }

        private void ControlAudio()
        {
            foreach (AudioSource audio in audio_sources)
            {
                if (Vector3.Distance(audio.transform.position, player.transform.position) < audio_proximity) audio.Play();
                else audio.Pause();
            }
        }
    }
}
