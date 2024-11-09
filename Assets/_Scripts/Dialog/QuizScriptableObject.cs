using UnityEngine;

[CreateAssetMenu(fileName = "NpcScriptableObject", menuName = "scriptableObjects/QuizQuestion")]
public class QuizScriptableObject : ScriptableObject
{
  public string question;
  public QuizAnswer[] answers;
}
