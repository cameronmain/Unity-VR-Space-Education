using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * a class responsible for handling answer checking and playing corresponding sounds
 */
public class Answer : MonoBehaviour {

    public bool isCorrect;
    public QuizManager quizManager;
    public AudioSource audioSource;

    public AudioClip correctSound;
    public AudioClip incorrectSound;

    public void CheckAnswer() {
        if (isCorrect) {
            Debug.Log("Correct.");
            PlayCorrectSound();
            quizManager.Correct(); // notify quiz manager about correct answer
        }
        else {
            Debug.Log("Wrong.");
            PlayIncorrectSound();
        }
    }

    private void PlayCorrectSound() {
        if (audioSource != null && correctSound != null) {
            audioSource.clip = correctSound;
            audioSource.Play();
        }
    }

    private void PlayIncorrectSound() {
        if (audioSource != null && incorrectSound != null) {
            audioSource.clip = incorrectSound;
            audioSource.Play();
        }
    }
}