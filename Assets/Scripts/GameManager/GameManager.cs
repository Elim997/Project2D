using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class GameManager : SingletonMonobehaviour<GameManager>
{
    [HideInInspector] public GameState gameState;

    // Start is called before the first frame update
    private void Start()
    {
        gameState = GameState.gameStarted;
    }

    // Update is called once per frame
    private void Update()
    {
        HandleGameState();

        // Test in future
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameState = GameState.restartGame;
        }
    }

    private void HandleGameState()
    {
        switch (gameState)
        {
            case GameState.gameStarted:
                // Play first wave somthing like PlayWave()
                gameState = GameState.playingLevel;
                break;
        }
    }

    // private void PlayWave() ( int waveNumberIndex ){}

    private void OnValidate()
    {
       // HelperUtilities.ValidateCheckEnumerableValues(this,nameof(waveNumber))
    }
}
