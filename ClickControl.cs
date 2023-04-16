using UnityEngine;
using UnityEngine.Events;

public static class ClickControl
{
    // Time limit for a click (in seconds)
    private const float clickTimeLimit = 0.2f;

    // Time limit between two clicks for a double click (in seconds)
    private const float doubleClickTimeLimit = 0.3f;

    // Record the time when the mouse button was last pressed down
    private static float lastMouseDownTime;

    // Record the position of the last mouse click
    private static Vector2 lastClickPosition;

    // Event that is invoked when a proper mouse click occurs
    public static UnityEvent onClick = new UnityEvent();

    // Event that is invoked when a proper double click occurs
    public static UnityEvent onDoubleClick = new UnityEvent();

    // Update is called once per frame
    public static void Update()
    {
        // Check if the left mouse button was pressed down
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the time limit between two clicks for a double click was not exceeded
            if (Time.time - lastMouseDownTime <= doubleClickTimeLimit && (Input.mousePosition - lastClickPosition).magnitude <= 10)
            {
                // A proper double click occurred
                onDoubleClick.Invoke();
            }
            else if (Time.time - lastMouseDownTime <= clickTimeLimit)
            {
                // A proper mouse click occurred
                onClick.Invoke();
            }

            // Record the time and position of the last mouse click
            lastMouseDownTime = Time.time;
            lastClickPosition = Input.mousePosition;
        }
    }
}
