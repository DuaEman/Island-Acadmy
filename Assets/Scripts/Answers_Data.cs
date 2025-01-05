using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Answers_Data : MonoBehaviour
{
   [Header ("UI Elements")]
   [SerializeField] TextMeshProUGUI infoTextObject;
   [SerializeField] Image toggle =null;
   [Header ("Textures")]
   [SerializeField] Sprite uncheckedToggle;
   [SerializeField] Sprite checkedToggle;

   private int _answerIndex = -1;
   private int AnswerIndex { get { return _answerIndex;}}
}
