using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;
using DTT.MinigameMemory.Demo;

[CommandAlias("playMemoryMinigame")]
public class MemoryMinigameCommand : Command
{
    public delegate void OnGameCompletedDelegate();
    public static event OnGameCompletedDelegate OnGameCompleted;

    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        await SceneManager.LoadSceneAsync("Demo");
        Scene myScene = SceneManager.GetSceneByName("Demo");
        FinishedMenu memoryMinigame = new FinishedMenu();
        GameObject[] rootObjects = myScene.GetRootGameObjects();

        foreach (GameObject obj in rootObjects)
        {
            if (obj.name == "Canvas")
            {
                int childCount = obj.transform.childCount;
                for (int i = 0; i < childCount; i++)
                {
                    Transform child = obj.transform.GetChild(i);
                    if (child.name == "UIManager")
                    {
                        childCount = child.transform.childCount;
                        for (int j = 0; j < childCount; j++)
                        {
                            Transform newChild = child.transform.GetChild(j);
                            if (newChild.name == "Menu_Finished")
                            {
                                memoryMinigame = newChild.GetComponent<FinishedMenu>();
                            }
                        }
                    }
                }
            }
        }

        if (memoryMinigame == null)
        {
            Debug.LogError("Could not find MemoryMinigame game object.");
            return;
        }
        else
        {
            memoryMinigame._restartButton.onClick.AddListener(RestartButtonClicked);
            memoryMinigame._homeButton.onClick.AddListener(HomeButtonClicked);
        }

        void RestartButtonClicked()
        {
            ReturnToNovel();
        }

        void HomeButtonClicked()
        {
            ReturnToNovel();
        }
    }
    async void ReturnToNovel()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync("ShowExitButton");
    }
}
