using Naninovel;
using Naninovel.Commands;
using UnityEngine;
using UnityEngine.UI;

[CommandAlias("mapShow")]
public class MapUpdate : Command
{
    public StringParameter Hero;
    public StringParameter Quest;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (Assigned(Quest))
        {
            if (Quest == "Room201")
            {
                GameObject.Find("Room_201").GetComponent<Image>().color = Color.white;
                GameObject.Find("Entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Room_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Room_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Quest == "Entrance")
            {
                GameObject.Find("Room_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Entrance").GetComponent<Image>().color = Color.white;
                GameObject.Find("Room_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Room_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Quest == "Room204")
            {
                GameObject.Find("Room_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Room_204").GetComponent<Image>().color = Color.white;
                GameObject.Find("Room_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Quest == "RoomMed")
            {
                GameObject.Find("Room_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Room_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Room_med").GetComponent<Image>().color = Color.white;
            }
        }

        if (Assigned(Hero))
        {
            if (Hero == "Room201")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Corridor201")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Corridor")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Entrance")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Corridor2")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Corridor204")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Room204")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "Staircase")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "CorridorMed")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.white;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.clear;
            }
            else if (Hero == "RoomMed")
            {
                GameObject.Find("Hero_201").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_201_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor1").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_entrance").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_cor2").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_204").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_stairs").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med_cor").GetComponent<Image>().color = Color.clear;
                GameObject.Find("Hero_med").GetComponent<Image>().color = Color.white;
            }
        }

        return UniTask.CompletedTask;
    }
}