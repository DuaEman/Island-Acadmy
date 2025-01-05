using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameEvent", menuName = "Quiz/new GameEvents")]
public class GameEvent : MonoBehaviour
{
public delegate void UpdateQuestionUICallback(Question question);
public UpdateQuestionUICallback UpdateQuestionUI;
public delegate void UpdateQuestionAnswerCallback(Answers_Data pickedAnswer);
public UpdateQuestionAnswerCallback UpdateQuestionAnswer;
public delegate void DisplayResolutionScreenCallback( UIManager.ResolutionScreenType type, int score);
public DisplayResolutionScreenCallback DisplayResolutionScreen;
public delegate void ScoreUpdatedCallback();
public ScoreUpdatedCallback ScoreUpdated;
public int CurrentFinalScore;


}
