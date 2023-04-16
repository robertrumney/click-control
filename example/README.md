## Example

Note that you should replace Example, HandleClick, and HandleDoubleClick with your own class and method names.

```csharp
using UnityEngine;
using UnityEngine.Events;

public class Example : MonoBehaviour
{
    private void Start()
    {
        // Subscribe to the onClick and onDoubleClick events
        MouseClicks.onClick.AddListener(HandleClick);
        MouseClicks.onDoubleClick.AddListener(HandleDoubleClick);
    }

    private void HandleClick()
    {
        Debug.Log("A proper mouse click occurred.");
    }

    private void HandleDoubleClick()
    {
        Debug.Log("A proper double click occurred.");
    }
}
```
