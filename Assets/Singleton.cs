using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	public static T instance;
	
	virtual protected void Awake()
	{
		instance = this as T;
	}
}
