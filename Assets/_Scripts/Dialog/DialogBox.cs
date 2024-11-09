using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour
{
  public TextMeshProUGUI textComponent;
  public Image avatar;
  public DialogScriptableObject dialog;
  public float textSpeed;
  public bool isRunning = false;
  private int index;
  // [SerializeField] private QuizBox quizObject;
  void Start()
  {
    // textComponent.text = string.Empty;
    // StartDialog();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      if (textComponent.text == dialog.lines[index].text)
      {
        NextLine();
      }
      else
      {
        StopAllCoroutines();
        textComponent.text = dialog.lines[index].text;
      }
    }
  }

  public void StartDialog(DialogScriptableObject dialogObject)
  {
    if (dialog)
    {
      Debug.Log("dialog.lines[index].text " + dialog.lines[index].text);
    }
    textComponent.text = string.Empty;
    index = 0;
    dialog = dialogObject;
    gameObject.SetActive(true);
    isRunning = true;
    StartCoroutine(TypeLine());
  }

  IEnumerator TypeLine()
  {
    // int avatarIndex = dialog.lines[index].spriteIndex;
    // this.avatar.sprite = dialog.avatars[avatarIndex];
    foreach (char c in dialog.lines[index].text.ToCharArray())
    {
      textComponent.text += c;
      yield return new WaitForSeconds(textSpeed);
    }
  }

  public void RestartDialog()
  {
    gameObject.SetActive(true);
    StartCoroutine(TypeLine());
  }

  public void NextLine()
  {
    if (dialog.lines[index].quizQuestion)
    {
      gameObject.SetActive(false);
      // quizObject.StartQuiz(dialog.lines[index].quizQuestion);
      return;
    }

    if (dialog.lines[index].changeSprite)
    {
      gameObject.SetActive(false);
    }

    if (index < dialog.lines.Length - 1)
    {
      index++;
      textComponent.text = string.Empty;
      StartCoroutine(TypeLine());
    }
    else
    {
      gameObject.SetActive(false);
      isRunning = false;
    }
  }
}