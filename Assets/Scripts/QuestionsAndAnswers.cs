using UnityEngine;


/*
 * class to hold data for a single quiz question and its answers
 */
[System.Serializable]
public class QuestionsAndAnswers {
    public string question;  // the quiz question
    public string[] answers;  // array of possible answers
    public int correctAnswer;// index of the correct answer in the answer array
}
