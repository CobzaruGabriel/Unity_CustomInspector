![Screenshot](https://github.com/jasonrwalters/Unity_CustomInspector/blob/master/screenshot.PNG)

# Description
Add the following from your script to display in the GameObject's inspector for easier debugging and testing.

# Usage
-----
###### Headers
```
[Header("Variables")]
public string text = "This is a string";
```

###### Spaces

```
public float var1; 
[Space(5f)] 
public float var2; 
```

###### Public Variables

```
public float var1;
public int var2;
public bool var3;
```

###### Private Variables

```
[SerializeField] 
private float var1; 
[SerializeField] 
private int var2; 
[SerializeField] 
private bool var3;
```

###### Sliders

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
Please create an issue ticket for questions and issues. Thank you.
