﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game.Model.SpiritItems
{
    public abstract class AbstractSpiritItem
    {

        #region Static
        private static Dictionary<string, AbstractSpiritItem> spiritDic = new Dictionary<string, AbstractSpiritItem>();

        public static void RegisterSpiritItem<T>(string name) where T : AbstractSpiritItem, new()
        {
            if (spiritDic.ContainsKey(name))
            {
                Debug.Log("重复注册SpiritMent");
                return;
            }
            var s = new T();
            s.Init(name);
            spiritDic.Add(name, s);
        }

        public static AbstractSpiritItem GetInstance(string name)
        {
            return spiritDic[name];
        }
        #endregion

        public string Name { get; protected set; }

        public abstract void OnEnable();

        public abstract void OnDisable();

        protected abstract void Execute();

        public virtual void Init(string args)
        {
            this.Name = args.Trim();
        }
    }
}