using UnityEngine;

public class CustomMethodExample : MonoBehaviour
{
    public void Foo(string text)
    {
        Debug.Log(text);
    }

    public void PrintKeyID(int id)
    {
        Debug.Log(id);
    }
}
