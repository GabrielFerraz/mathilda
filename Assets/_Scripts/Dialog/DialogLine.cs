
using UnityEngine;

[System.Serializable]
public class DialogLine
{
    public int spriteIndex;
    public string text;

    public bool gotItem;

    public QuizScriptableObject quizQuestion;

    public Vector3 transitionTo;
    public bool hasTransition;
    public bool facingRight;

    public bool changeSprite;
    public Sprite sprite;
    public Vector2 collider;
    public Vector2 offset;
    public float offsetDialog;
    public GameObject npc;
}