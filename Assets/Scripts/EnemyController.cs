using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    public int hp = 100;
    public UnityEvent onDeath;

    private void Start()
    {
        StartCoroutine(Hurt());
    }

    private IEnumerator Hurt()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            hp -= 20;

            if (hp <= 0)
            {
                // FindAnyObjectByType<GameManager>().AddDeathAmount();
                onDeath.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
