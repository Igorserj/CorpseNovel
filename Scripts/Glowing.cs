using UnityEngine;
using UnityEngine.UI;

public class Glowing : MonoBehaviour
{
    public GameObject go;
    private Animator animator;

    public void Glow()
    {
        animator = go.GetComponent<Animator>();
        animator.Play("Glow");
        //go.GetComponent<Image>().color = Color.white;
    }
    public void UnGlow()
    {
        animator = go.GetComponent<Animator>();
        animator.Play("Unglow");
        //go.GetComponent<Image>().color = Color.clear;
    }
}
