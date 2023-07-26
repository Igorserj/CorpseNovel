using Naninovel;
using Naninovel.Commands;
using UnityEngine;
using UnityEngine.UI;

[CommandAlias("questUpd")]
public class UpdateQuest : Command
{
    public StringParameter Title;
    public StringParameter Description;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var titleText = GameObject.Find("Title").GetComponent<Text>();
        var descriptionText = GameObject.Find("Description").GetComponent<Text>();

        if (Assigned(Title))
        {
            titleText.text = Title;
        }
        if (Assigned(Description)) 
        {
            descriptionText.text = Description;
        }

            return UniTask.CompletedTask;
    }
}