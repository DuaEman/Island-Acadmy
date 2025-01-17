using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Question[] _questions=null;
    public Question[] Question { get { return _questions;}}

    [SerializeField] GameEvent events= null;
    
    private List<Answers_Data> PickedAnswers = new List<Answers_Data> ();
        private  List<int> FinishedQuestions = new List<int>();
    private int currentQuestion =0;

    void Start()
    {
        LoadQuestions();

        foreach(var question in Question){
            Debug.Log(question.Info);
        }
      //  Display();
    }
   public void EraseAnswers(){
    PickedAnswers = new List<Answers_Data>();
   }
    void Display()
    {
        EraseAnswers();
        var question = GetRandomQuestion();
        if(events.UpdateQuestionUI!= null)
        {
            events.UpdateQuestionUI(question);
        } else {
            Debug.LogWarning("Ups! Something went wrong while trying to display new Question UI Data. GameEvents.UpdateQuestionUI is null. Issue occured in GameManager.Display() method."); 
        }
    }
Question GetRandomQuestion()
{
    var randomIndex = GettRandomQuestionIndex();
    currentQuestion= randomIndex;
    return Question[currentQuestion];
}

int GettRandomQuestionIndex()
{

var random =0;
if( FinishedQuestions.Count < Question.Length)
{
    do{

random = UnityEngine.Random.Range( 0, Question.Length);
    }while(FinishedQuestions. Contains(random)|| random == currentQuestion);
}
 return random;
}

void LoadQuestions()
{
    object[] objs = Resources.LoadAll("Questions", typeof(Question));
    _questions = new Question[objs.Length];
    for(int i=0; i< objs.Length; i++)
    {
        _questions[i] = (Question)objs[i];
    }
}
}
