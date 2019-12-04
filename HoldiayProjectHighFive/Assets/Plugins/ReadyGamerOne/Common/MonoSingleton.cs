﻿using UnityEngine;
namespace ReadyGamerOne.Common
{
    /// <summary>
    /// MonoBehavior单例泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MonoSingleton<T> : MonoBehaviour
        where T : MonoSingleton<T>
    {
        private static T _instance = null;
        public static T Instance {
            get {
                if (_instance == null) {
                    _instance = FindObjectOfType(typeof(T)) as T;
                    if (_instance == null) {
                        GameObject obj = new GameObject();
                        _instance = (T)obj.AddComponent(typeof(T));
                        obj.hideFlags = HideFlags.DontSave;
                        // obj.hideFlags = HideFlags.HideAndDontSave;
                        obj.name = typeof(T).Name;
                    }
                }
                return _instance;
            }
        }

        protected virtual void Awake() {
            DontDestroyOnLoad(this.gameObject);
            if (_instance == null) {
                _instance = this as T;
            }
            else {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
