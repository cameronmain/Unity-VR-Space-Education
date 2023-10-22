using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

/*
 * manager to handle quiz logic
 */
public class QuizManager : MonoBehaviour {
    public List<QuestionsAndAnswers> QnA; 
    public GameObject[] options;  // array of answer option gameObjects
    public int currentQuestion;  // index of the current question

    public Text questionText;

    public AudioSource audioSource;
    public AudioClip winSound;

    public GameObject quizPanel;  // panel for displaying the quiz
    public GameObject winPanel;  // panel for displaying win screen

    private void Start() {
        GenerateQuestion();  // generate the first question on start
    }

    // method to handle correct answer selection
    public void Correct() {
        QnA.RemoveAt(currentQuestion);  // remove the current question from the list of possible questions
        GenerateQuestion();  // generate the next question
    }

    // method to set the answers on the answer option gameObjects
    void SetAnswers() {
        int correctAnswerIndex = QnA[currentQuestion].correctAnswer - 1;  // subtract 1 to convert to zero-based indexing

        for (int i = 0; i < options.Length; i++) {
            options[i].GetComponent<Answer>().isCorrect = (i == correctAnswerIndex);  // set isCorrect based on index comparison
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].answers[i];
        }
    }

    // method to generate a new question
    void GenerateQuestion() {
        if (QnA.Count == 0) {
            quizPanel.SetActive(false);  // hide the quiz panel if there are no more questions
            winPanel.SetActive(true);  // show the win panel if there are no more questions
            // all questions have been answered, play the win audio
            PlayWinSound();
        } else {
            currentQuestion = Random.Range(0, QnA.Count);  // randomly select a new question
            questionText.text = QnA[currentQuestion].question;  // set the question text
            SetAnswers();  // set the answer options
        }
    }

    // method to play the win sound
    private void PlayWinSound() {
        if (audioSource != null && winSound != null) {
            audioSource.clip = winSound;  // set the audio clip
            audioSource.Play();  // play the audio
        }
    }
}
