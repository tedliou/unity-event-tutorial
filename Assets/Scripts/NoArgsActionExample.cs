using UnityEngine;
using UnityEngine.Events;

public class NoArgsActionExample : MonoBehaviour
{
    public event UnityAction onKeyTrigger;

    private void Start()
    {
        onKeyTrigger += CustomMethod;
        onKeyTrigger += () =>
        {
            Debug.Log("Bye!");
        };
    }

    private void CustomMethod()
    {
        Debug.Log("Hi there!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onKeyTrigger.Invoke();
        }
    }
}
