using UnityEngine;

// <T> means Generics
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour
    where T : MonoBehaviour
{
    private static T instance; // this makes singleton globally accessible
    public static T Instance // getter
    {
        get { return instance; }
    }

    // protected: is accessible within its own class and any derived classes, but not from outside the class hierarchy.
    // virtual: can be over written by inheriting classes
    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
