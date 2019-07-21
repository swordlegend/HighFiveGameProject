﻿using Game.Control.PersonSystem;
using Game.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Const;
using Game.Data;
using UnityEngine.Assertions;

namespace Game.Control.SkillSystem
{
    /// <summary>
    /// 音效触发器
    /// </summary>
    public class AudioTrigger : AbstractSkillTrigger
    {
        private string audioName;

        public override void LoadTxt(string args)//type, int id,float startTime, float lastTime, string args = "")
        {
            var strs = args.Split(TxtManager.SplitChar);
            Assert.IsTrue(strs.Length >= BasePropertyCount+1);
            this.audioName = strs[BasePropertyCount].Trim();
            base.LoadTxt(string.Join(TxtManager.SplitChar.ToString(), strs, 0, this.BasePropertyCount));
        }

        public override void Execute(AbstractPerson self)
        {
            MainLoop.Instance.ExecuteLater(_Execute, this.StartTime, self);
        }

        public override string Sign
        {
            get
            {
                return TxtSign.audio;
            }
        }

        private void _Execute(AbstractPerson ap)
        {
            AudioMgr.Instance.PlayEffect(this.audioName, ap.obj.transform.position);

        }
    }
}
