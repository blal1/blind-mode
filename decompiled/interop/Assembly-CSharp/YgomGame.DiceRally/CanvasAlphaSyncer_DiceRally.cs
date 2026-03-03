using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F8C")]
public class CanvasAlphaSyncer_DiceRally : CanvasAlphaSyncer
{
	[Serializable]
	[Token(Token = "0x2000F8D")]
	private class TargetData_Color
	{
		[Token(Token = "0x400A8AD")]
		[FieldOffset(Offset = "0x10")]
		public Renderer renderer;

		[Token(Token = "0x400A8AE")]
		[FieldOffset(Offset = "0x18")]
		public string paramName;

		[Token(Token = "0x400A8AF")]
		[FieldOffset(Offset = "0x20")]
		private Color baseColor;

		[Token(Token = "0x17000EE2")]
		public Color BaseColor
		{
			[Token(Token = "0x6005E57")]
			[Address(RVA = "0xA49A40", Offset = "0xA48C40", VA = "0x180A49A40")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6005E58")]
			[Address(RVA = "0xA49A50", Offset = "0xA48C50", VA = "0x180A49A50")]
			set
			{
			}
		}

		[Token(Token = "0x6005E59")]
		[Address(RVA = "0xA499F0", Offset = "0xA48BF0", VA = "0x180A499F0")]
		public TargetData_Color()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000F8E")]
	private class TargetData_Alpha
	{
		[Token(Token = "0x400A8B0")]
		[FieldOffset(Offset = "0x10")]
		public Renderer renderer;

		[Token(Token = "0x400A8B1")]
		[FieldOffset(Offset = "0x18")]
		public string paramName;

		[Token(Token = "0x400A8B2")]
		[FieldOffset(Offset = "0x20")]
		private float baseAlpha;

		[Token(Token = "0x17000EE3")]
		public float BaseAlpha
		{
			[Token(Token = "0x6005E5A")]
			[Address(RVA = "0x64BF80", Offset = "0x64B180", VA = "0x18064BF80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6005E5B")]
			[Address(RVA = "0xA499E0", Offset = "0xA48BE0", VA = "0x180A499E0")]
			set
			{
			}
		}

		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0xA49990", Offset = "0xA48B90", VA = "0x180A49990")]
		public TargetData_Alpha()
		{
		}
	}

	[Token(Token = "0x400A8AA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<TargetData_Color> m_Targets_Color;

	[Token(Token = "0x400A8AB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<TargetData_Alpha> m_Targets_Alpha;

	[Token(Token = "0x400A8AC")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsDirtyCollectBaseComponents;

	[Token(Token = "0x6005E53")]
	[Address(RVA = "0xA30040", Offset = "0xA2F240", VA = "0x180A30040", Slot = "17")]
	public override void Apply()
	{
	}

	[Token(Token = "0x6005E54")]
	[Address(RVA = "0xA30670", Offset = "0xA2F870", VA = "0x180A30670", Slot = "18")]
	protected override void CollectCanvasGroups()
	{
	}

	[Token(Token = "0x6005E55")]
	[Address(RVA = "0xA30370", Offset = "0xA2F570", VA = "0x180A30370")]
	private void CollectBaseComponents()
	{
	}

	[Token(Token = "0x6005E56")]
	[Address(RVA = "0xA30690", Offset = "0xA2F890", VA = "0x180A30690")]
	public CanvasAlphaSyncer_DiceRally()
	{
	}
}
