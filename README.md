![Screenshot](https://github.com/jasonrwalters/Unity_CustomInspector/blob/master/screenshot.PNG)

# Description
Display variables created in scripts to be displayed in a GameObject's inspector.
- Useful for adjusting game parameters during play tests in the Unity Editor.
- Useful for debugging values when you do not need to draw messages to the screen.

# Usage

###### Public Variables
Public variables will be displayed in the inspector.  Note, `public static` variables will NOT be displayed in the inspector.
```
public float var1;
public int var2;
public bool var3;
```


###### Private Variables
In order to see private variables in the inspector, you must place `[SerializeField]` ahead of each item.
```
[SerializeField] 
private float var1; 
[SerializeField] 
private int var2; 
[SerializeField] 
private bool var3;
```


###### Headers
```
[Header("Variables")]
public string text = "This is a string";
```


###### Spaces
Use `[Space(height)]` between each item that requires a space.  Height is in pixels.
```
public float var1; 
[Space(5f)] 
public float var2;
[Space(10f)]
public float var3;
```


###### Sliders
Place `[Range(min, max)]` ahead of variables that need a slider in the inspector.  Requires a minimum and maximum value.
```
[Range(1f, 10f)] 
public float var1; 
```


###### Drop Downs
```
public enum Selector 
{ 
  One = 0, 
  Two = 1, 
  Three = 2, 
  Four = 3 
}
public Selector select = Selector.One;
```


###### Colors
```
public Color rgba;
public Gradient gradient;
```

# Support
Please create an [issue ticket](https://github.com/jasonrwalters/Unity_CustomInspector/issues) for questions and issues. Thank you.
