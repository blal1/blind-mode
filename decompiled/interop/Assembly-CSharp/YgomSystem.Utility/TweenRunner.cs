using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x200041D")]
public class TweenRunner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200041E")]
	public class TweenGroup
	{
		[Token(Token = "0x400144C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Label;

		[Token(Token = "0x400144D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Tween> m_Tweens;

		[Token(Token = "0x1700026B")]
		public string label
		{
			[Token(Token = "0x6001A90")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A91")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public List<Tween> tweens
		{
			[Token(Token = "0x6001A92")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x5F2B90", Offset = "0x5F1D90", VA = "0x1805F2B90")]
		public TweenGroup()
		{
		}
	}

	[Token(Token = "0x400144A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TweenGroup> m_TweenGroups;

	[Token(Token = "0x400144B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_PlayLabel;

	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x5F3370", Offset = "0x5F2570", VA = "0x1805F3370")]
	public void TweenCollect(bool includeChildren = false)
	{
	}

	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x5F3220", Offset = "0x5F2420", VA = "0x1805F3220")]
	public List<Tween> TryGetTweens(string label)
	{
		return null;
	}

	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x5F2C30", Offset = "0x5F1E30", VA = "0x1805F2C30")]
	public void Evaluate(string playLabel)
	{
	}

	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x5F2E90", Offset = "0x5F2090", VA = "0x1805F2E90")]
	public void PlayOverride(string playLabel)
	{
	}

	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x5F3720", Offset = "0x5F2920", VA = "0x1805F3720")]
	public TweenRunner()
	{
	}
}
