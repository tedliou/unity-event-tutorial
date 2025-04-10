using UnityEngine;
using UnityEngine.Events;

public class NoArgsEventExample : MonoBehaviour
{
    public UnityEvent onKeyTrigger;

    private void Start()
    {
        onKeyTrigger.AddListener(CustomMethod);
        onKeyTrigger.AddListener(() =>
        {
            Debug.Log("Bye!");
        });
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
