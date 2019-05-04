﻿using System;
using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Data;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Model.RankSystem
{
	public class L1Rank : AbstractLargeRank
	{
		private float attackMut;

		public override bool BreakLimit()
		{
			return true;
		}

		public override void LoadTxt(string args)
		{
			var strs = args.Split(TxtManager.SplitChar);
			Debug.Log("L1Rank.strs.Length: "+strs.Length);
			Assert.IsTrue(strs.Length>=BasePropertyCount+1);
			this.attackMut = Convert.ToSingle(strs[BasePropertyCount].Trim());
			base.LoadTxt(string.Join(TxtManager.SplitChar.ToString(),strs,0,BasePropertyCount));
		}

		public override void ImprovePlayer()
		{
			Global.GlobalVar.G_Player.attackMultipulier *= this.attackMut;
		}

		public override string Sign
		{
			get { return DataSign.L1Rank; }
		}
	}
}
