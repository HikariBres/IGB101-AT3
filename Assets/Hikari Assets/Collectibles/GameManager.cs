using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickups = 0;
    public int maxPickups = 4;
    public bool levelComplete = false; 

    public Text pickupText;

    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    private void LevelCompleteCheck(){

        if (currentPickups >= maxPickups)
            levelComplete = true;
        else 
            levelComplete = false;

    }
    private void UpdateGUI(){
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }
    private void PlayAudioSamples(){
        for (int i = 0; i < audioSources.Length; i++){
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity){
                if(!audioSources[i].isPlaying){
                    audioSources[i].Play();
                }
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }
}
