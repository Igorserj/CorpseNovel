using Naninovel;
using Naninovel.Commands;
using System;
using UnityEngine;
using UnityEngine.UI;

[CommandAlias("questUpd")]
public class UpdateQuest : Command
{
    public StringParameter questNo;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (Assigned(questNo))
        {
            if (questNo=="1") {
                var name = GameObject.Find("QuestNameLabel1").GetComponent<Text>();
                var desc = GameObject.Find("QuestDescLabel1").GetComponent<Text>();
                name.enabled = true;
                desc.enabled = true;

                name = GameObject.Find("QuestNameLabel2").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel2").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel3").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel3").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel4").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel4").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel5").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel5").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel6").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel6").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;
            }

            else if (questNo == "2")
            {
                var name = GameObject.Find("QuestNameLabel1").GetComponent<Text>();
                var desc = GameObject.Find("QuestDescLabel1").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel2").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel2").GetComponent<Text>();
                name.enabled = true;
                desc.enabled = true;

                name = GameObject.Find("QuestNameLabel3").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel3").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel4").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel4").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel5").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel5").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel6").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel6").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;
            }
            else if (questNo == "3")
            {
                var name = GameObject.Find("QuestNameLabel1").GetComponent<Text>();
                var desc = GameObject.Find("QuestDescLabel1").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel2").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel2").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel3").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel3").GetComponent<Text>();
                name.enabled = true;
                desc.enabled = true;

                name = GameObject.Find("QuestNameLabel4").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel4").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel5").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel5").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel6").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel6").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;
            }
            else if (questNo == "4")
            {
                var name = GameObject.Find("QuestNameLabel1").GetComponent<Text>();
                var desc = GameObject.Find("QuestDescLabel1").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel2").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel2").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel3").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel3").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel4").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel4").GetComponent<Text>();
                name.enabled = true;
                desc.enabled = true;

                name = GameObject.Find("QuestNameLabel5").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel5").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel6").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel6").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;
            }
            else if (questNo == "5")
            {
                var name = GameObject.Find("QuestNameLabel1").GetComponent<Text>();
                var desc = GameObject.Find("QuestDescLabel1").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel2").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel2").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel3").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel3").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel4").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel4").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel5").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel5").GetComponent<Text>();
                name.enabled = true;
                desc.enabled = true;

                name = GameObject.Find("QuestNameLabel6").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel6").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;
            }
            else if (questNo == "6")
            {
                var name = GameObject.Find("QuestNameLabel1").GetComponent<Text>();
                var desc = GameObject.Find("QuestDescLabel1").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel2").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel2").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel3").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel3").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel4").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel4").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel5").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel5").GetComponent<Text>();
                name.enabled = false;
                desc.enabled = false;

                name = GameObject.Find("QuestNameLabel6").GetComponent<Text>();
                desc = GameObject.Find("QuestDescLabel6").GetComponent<Text>();
                name.enabled = true;
                desc.enabled = true;
            }
        }

        return UniTask.CompletedTask;
    }
}