# ClickControl

ClickControl is a simple and lightweight Unity utility for handling single and double mouse clicks in your game. It works by using static events to trigger user-defined actions when a proper single or double click occurs.

## Features

- Easy to implement and use in your Unity project
- Customizable time limits for click and double click actions
- Detects single and double mouse clicks
- Provides UnityEvents for custom actions

## Usage

1. Add the ClickControl script to your Unity project
2. In any script that needs to respond to click or double click events, subscribe to the `onClick` or `onDoubleClick` events, like this:

```csharp
private void OnEnable()
{
    ClickControl.onClick.AddListener(OnSingleClick);
    ClickControl.onDoubleClick.AddListener(OnDoubleClick);
}

private void OnDisable()
{
    ClickControl.onClick.RemoveListener(OnSingleClick);
    ClickControl.onDoubleClick.RemoveListener(OnDoubleClick);
}

private void OnSingleClick()
{
    // Your single click logic here
}

private void OnDoubleClick()
{
    // Your double click logic here
}
```


## Configuration
You can configure the time limits for click and double click actions directly in the ClickControl script:

`clickTimeLimit`: The maximum duration (in seconds) for a single click
`doubleClickTimeLimit`: The maximum time interval (in seconds) between two clicks for a double click

### License
This project is licensed under the MIT License - see the LICENSE file for details.
