using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

/*
 * class to handle planet instantiation and trigger cutscene playback
 */
public class PlanetInstantiator : MonoBehaviour
{
    public delegate void CutsceneStoppedHandler(GameObject planetObject);
    public static event CutsceneStoppedHandler OnCutsceneStoppedEvent;  // event triggered when cutscene stops
    
    public Transform instantiationPosition;  // position where new planet will be instantiated
    private GameObject previousPlanet;  // reference to the previously instantiated planet
    public PlayableDirector cutscene;  // reference to the PlayableDirector to control cutscene playback

    private void OnEnable()
    {
        PlanetController.OnPlanetMovedToCenter += InstantiatePlanet;  // subscribe to planet moved to center event
        cutscene.stopped += OnCutsceneStopped;  // subscribe to the stopped event of the cutscene
    }

    private void OnDisable()
    {
        PlanetController.OnPlanetMovedToCenter -= InstantiatePlanet;  // unsubscribe from planet moved to center event
        cutscene.stopped -= OnCutsceneStopped;  // unsubscribe from the stopped event of the cutscene
    }

    // method to instantiate a new planet outside the ship when another planet is moved to center
    private void InstantiatePlanet(GameObject planetObject)
    {
        if (planetObject != null && instantiationPosition != null)
        {
            // destroy the previous planet if it exists
            if (previousPlanet != null)
            {
                Destroy(previousPlanet);
            }

            // instantiate a duplicate of the planetObject at the specified position
            GameObject newPlanet = Instantiate(planetObject, instantiationPosition.position, Quaternion.identity);

            // set the scale of the new planet to be much larger
            newPlanet.transform.localScale = Vector3.one * 20; /*arbitrary number chosen that fits well for all planets 
                                                                in the scene but could change this to scale with each 
                                                                planet's relative size later. */
            
            // setting the new planet as a child of instantiationPosition
            newPlanet.transform.SetParent(instantiationPosition, true); 

            // set the newly instantiated planet as the previous planet
            previousPlanet = newPlanet;

            // play the space warp cutscene
            PlayCutscene();
        }
    }
    
    private void PlayCutscene() 
    {
        cutscene.Play();
    }

    // method to be called when the cutscene has finished playing
    private void OnCutsceneStopped(PlayableDirector director) {
        OnCutsceneStoppedEvent?.Invoke(previousPlanet);  // trigger event when cutscene stops
        Debug.Log("Cutscene finished playing.");   
    }

    private void Update()
    {
        if (previousPlanet != null)
        {
            // rotate the planet counter-clockwise around the y-axis
            previousPlanet.transform.Rotate(0, Time.deltaTime * 5f, 0);
        }
    }
}
