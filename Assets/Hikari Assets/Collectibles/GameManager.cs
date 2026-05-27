using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickups = 0;
    public int maxPickups = 4;
    public bool levelComplete = false; 

    private void LevelCompleteCheck(){

        if (currentPickups >= maxPickups)
            levelComplete = true;
        else 
            levelComplete = false;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
    }
}
