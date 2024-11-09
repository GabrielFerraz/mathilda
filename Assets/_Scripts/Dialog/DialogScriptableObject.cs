using UnityEngine;

[CreateAssetMenu(fileName = "NpcScriptableObject", menuName = "scriptableObjects/Dialog")]
public class DialogScriptableObject : ScriptableObject
{
  public Sprite[] avatars;
  public DialogLine[] lines;
}
