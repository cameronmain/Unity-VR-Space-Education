using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/*
 * controller to manage interaction with a planet object in XR
 */
public class PlanetController : MonoBehaviour
{
    public delegate void PlanetMovedToCenter(GameObject planetObject);
    // event triggered when a planet is moved to the center
    public static event PlanetMovedToCenter OnPlanetMovedToCenter;

    private bool hasBeenMovedToCenter = false; // flag to track if the planet has been moved to center

    public XRBaseInteractor interactor; // reference to the XR interactor component

    private void OnEnable()
    {
        // subscribe to the select and deselect events of the interactor
        interactor.onSelectEntered.AddListener(HandleSelection);
        interactor.onSelectExited.AddListener(HandleDeselection);
    }

    private void OnDisable()
    {
        // unsubscribe from the select and deselect events of the interactor
        interactor.onSelectEntered.RemoveListener(HandleSelection);
        interactor.onSelectExited.RemoveListener(HandleDeselection);
    }

    // handles the selection of an interactable
    private void HandleSelection(XRBaseInteractable interactable)
    {
        if (!hasBeenMovedToCenter)
        {
            Debug.Log("Interactor is selecting an object: " + interactable.name);
            // trigger the event when a planet is selected and moved to center
            OnPlanetMovedToCenter?.Invoke(interactable.gameObject);

            // set the flag to true to indicate that it has been moved to center
            hasBeenMovedToCenter = true;
        }
    }

    // handles the deselection of an interactable
    private void HandleDeselection(XRBaseInteractable interactable)
    {
        // reset the flag when the interactor is not selecting an object
        hasBeenMovedToCenter = false;
        Debug.Log("Interactor is not selecting an object.");
    }
}
