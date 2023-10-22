using UnityEngine;
using UnityEngine.UI;
/*
 * controller to manage UI updates and audio playback based on planet interaction
 */
public class UIAndAudioController : MonoBehaviour
{
    public Text planetNameText;  
    public Text planetDescriptionText;  
    public AudioSource audioSource;  // audio source to play planet narration audio

    private void OnEnable()
    {
        // subscribe to the event when this script is enabled
        PlanetInstantiator.OnCutsceneStoppedEvent += HandlePlanetMovedToCenter;
    }

    private void OnDisable()
    {
        // unsubscribe from the event when this script is disabled
        PlanetInstantiator.OnCutsceneStoppedEvent -= HandlePlanetMovedToCenter;
    }

    // handler for when a planet is moved to center after cutscene
    private void HandlePlanetMovedToCenter(GameObject planetObject)
    {
        if (planetObject == null) {
            return;  
        }
        // extract planet info from the GameObject's Planet component
        Planet planetInfo = planetObject.GetComponent<Planet>();

        // update the UI text fields with the extracted planet info
        planetNameText.text = planetInfo.planetName;
        planetDescriptionText.text = planetInfo.planetDescription;

        // set the audio clip to the planet's audio and play it
        audioSource.clip = planetInfo.planetAudio;
        audioSource.Play();
    }
}