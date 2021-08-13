# Key Input, difference of OnGUI and Update

## description

``` c#
public class InputManager : MonoBehaviour {
    [SerializeField]
    GUIManager guiManager;
    [SerializeField]
    GUIManager guiMangerOnGUI;

    private Dictionary<KeyCode, string> keyCodes = new Dictionary<KeyCode, string> ();

    void Start () {
        // 入力判定用にFとJを設定
        keyCodes.Add (KeyCode.F, "F");
        keyCodes.Add (KeyCode.J, "J");
    }

    void Update () {
        foreach (KeyValuePair<KeyCode, string> kvp in keyCodes) {
            if (Input.GetKeyUp (kvp.Key)) {
                GetKeyUp (guiManager, kvp.Value);
            }
        }
    }

    void OnGUI () {
        if (Event.current.type == EventType.KeyUp) {
            string input = keyCodes[Event.current.keyCode];
            if (input != null) {
                GetKeyUp (guiMangerOnGUI, input);
            }
        }
    }

    private void GetKeyUp (GUIManager manager, string input) {
        manager.pushString (input);
    }
}

```