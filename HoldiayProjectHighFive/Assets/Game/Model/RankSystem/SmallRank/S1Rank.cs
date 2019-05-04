﻿using System;
using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Data;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Model.RankSystem
{
	public class S1Rank : AbstractSmallRank
	{
		private float hitback;
		public override void ImprovePlayer()
		{
			Global.GlobalVar.G_Player.hitBackSpeed += this.hitback;
		}

		public override void LoadTxt(string args)
		{
			var strs = args.Split(TxtManager.SplitChar);
			Assert.IsTrue(strs.Length >= BasePropertyCount + 1);
			this.hitback = Convert.ToSingle(strs[BasePropertyCount].Trim());
			base.LoadTxt(string.Join(TxtManager.SplitChar.ToString(),strs,0,BasePropertyCount));
		}

		public override string Sign
		{
			get { return DataSign.S1Rank; }
		}
	}
}

