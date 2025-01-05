using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

[Serializable()]
public struct UIManagerParameters
{
    [Header("Answers Options")]
    [SerializeField] float margins;
    public float Margins {get { return margins;}}
}
[Serializable()]
public struct UIElements
{
[SerializeField] RectTransform answersContentArea;
public RectTransform AnswersContentArea {get { return answersContentArea;}} 
[SerializeField] TextMeshProUGUI questionInfoTextObject;
public TextMeshProUGUI QuestionInfoTextObject {get { return questionInfoTextObject;}}
[SerializeField] TextMeshProUGUI scoreText;
public TextMeshProUGUI ScoreText {get { return scoreText;}}
[Space]

[SerializeField] TextMeshProUGUI highScoreText;
public TextMeshProUGUI HighScoreText {get { return highScoreText;}}
}


public class UIManager : MonoBehaviour
{
    public enum ResolutionScreenType{ Correct, Incorrect, Finish}
    [Header("References")]
    [SerializeField] GameEvent events;
    [Header("UI Elements (Prefabs)")]
    [SerializeField] Answers_Data answersPrefabs;

    [SerializeField] UIManagerParameters parameters;
}
