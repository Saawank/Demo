using JMRSDK.InputModule;

using UnityEngine;

public class InterfaceExample : MonoBehaviour, ISelectHandler, ISelectClickHandler, IFocusable, ISwipeHandler, ITouchHandler, IBackHandler, IMenuHandler, IVoiceHandler, IFn1Handler, IFn2Handler, IManipulationHandler

{

    public void OnBackAction()

    {

        Debug.Log("OnBackAction");

    }

    public void OnFn1Action()

    {

        Debug.Log("OnFn1Action");

    }

    public void OnFn2Action()

    {

        Debug.Log("OnFn2Action");

    }

    public void OnFocusEnter()

    {

        Debug.Log("OnFocusEnter");

    }

    public void OnFocusExit()

    {

        Debug.Log("OnFocusExit");

    }

    public void OnManipulationCompleted(ManipulationEventData eventData)

    {

        Debug.Log("OnManipulationCompleted");

    }

    public void OnManipulationStarted(ManipulationEventData eventData)

    {

        Debug.Log("OnManipulationStarted");

    }

    public void OnManipulationUpdated(ManipulationEventData eventData)

    {

        Debug.Log("OnManipulationUpdated");

    }

    public void OnMenuAction()

    {

        Debug.Log("OnMenuAction");

    }

    public void OnSelectClicked(SelectClickEventData eventData)

    {

        Debug.Log("OnSelectClicked");

    }

    public void OnSelectDown(SelectEventData eventData)

    {

        Debug.Log("OnSelectDown");

    }

    public void OnSelectUp(SelectEventData eventData)

    {

        Debug.Log("OnSelectUp");

    }

    public void OnSwipeCanceled(SwipeEventData eventData)

    {

        Debug.Log("OnSwipeCanceled");

    }

    public void OnSwipeCompleted(SwipeEventData eventData)

    {

        Debug.Log("OnSwipeCompleted");

    }

    public void OnSwipeDown(SwipeEventData eventData, float delta)

    {

        Debug.Log("OnSwipeDown");

    }

    public void OnSwipeLeft(SwipeEventData eventData, float delta)

    {

        Debug.Log("OnSwipeLeft");

    }

    public void OnSwipeRight(SwipeEventData eventData, float delta)

    {

        Debug.Log("OnSwipeRight");

    }

    public void OnSwipeStarted(SwipeEventData eventData)

    {

        Debug.Log("OnSwipeStarted");

    }

    public void OnSwipeUp(SwipeEventData eventData, float delta)

    {

        Debug.Log("OnSwipeUp");

    }

    public void OnSwipeUpdated(SwipeEventData eventData, Vector2 delta)

    {

        Debug.Log("OnSwipeUpdated");

    }

    public void OnVoiceAction()

    {

        Debug.Log("OnVoiceAction");

    }

    public void OnTouchStart(TouchEventData eventData, Vector2 TouchData)

    {

        Debug.Log("OnTouchStarted " + TouchData.ToString());

    }

    public void OnTouchStop(TouchEventData eventData, Vector2 TouchData)

    {

        Debug.Log("OnTouchStop " + TouchData.ToString());

    }

    public void OnTouchUpdated(TouchEventData eventData, Vector2 TouchData)

    {

        Debug.Log("OnTouchUpdated " + TouchData.ToString());

    }

}