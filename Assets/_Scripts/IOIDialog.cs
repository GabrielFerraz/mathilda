using UnityEngine;

public class IOIDialog : InteractObjectInteraction
{
    public DialogBox _dialogBox;
    public DialogScriptableObject dialog;

    public override void Interact()
    {
        Debug.Log("Dialog");
        _dialogBox.StartDialog(dialog);
    }
}