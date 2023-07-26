using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

[CommandAlias("playMemoryMinigame")]
public class MemoryMinigameCommand : Command
{
    public delegate void OnGameCompletedDelegate();
    public static event OnGameCompletedDelegate OnGameCompleted;

    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        // Load the Demo scene
        await SceneManager.LoadSceneAsync("Demo");

        // Get the DTT Minigame - Memory game object
        var memoryMinigame = GameObject.Find("MemoryMinigame");
        if (memoryMinigame == null)
        {
            Debug.LogError("Could not find MemoryMinigame game object.");
            return;
        }

        // Start the minigame
        memoryMinigame.SetActive(true);

        // Subscribe to the game finished event
        OnGameCompleted += HandleGameFinished;
    }

    private void HandleGameFinished()
    {
        // Unsubscribe from the game finished event
        OnGameCompleted -= HandleGameFinished;

        Debug.Log("finish");
    }
}
