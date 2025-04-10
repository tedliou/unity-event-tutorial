using UnityEngine;
using UnityEngine.Events;

public class ArgsEventExample : MonoBehaviour
{
    public UnityEvent<int> onKeyTrigger;

    private void Start()
    {
        onKeyTrigger.AddListener(CustomMethod);
        onKeyTrigger.AddListener(id =>
        {
            Debug.Log(id);
        });
    }

    private void CustomMethod(int id)
    {
        Debug.Log("Hi there!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            onKeyTrigger.Invoke(1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            onKeyTrigger.Invoke(2);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            onKeyTrigger.Invoke(3);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            onKeyTrigger.Invoke(4);
        }
    }
}
