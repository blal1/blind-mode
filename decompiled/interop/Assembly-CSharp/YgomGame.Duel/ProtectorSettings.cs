using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A6C")]
[CreateAssetMenu(fileName = "ProtectorSettings", menuName = "Scriptable Object/Create ProtectorSettings")]
public class ProtectorSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001A6D")]
	public class Info
	{
		[Token(Token = "0x400F38C")]
		[FieldOffset(Offset = "0x10")]
		public int protectorID;

		[Token(Token = "0x400F38D")]
		[FieldOffset(Offset = "0x14")]
		public float drawEffectIntensity;

		[Token(Token = "0x600AB9C")]
		[Address(RVA = "0x422710", Offset = "0x421910", VA = "0x180422710")]
		public Info()
		{
		}
	}

	[Token(Token = "0x400F387")]
	private const string path = "Duel/ScriptableObject/ProtectorSettings";

	[Token(Token = "0x400F388")]
	[FieldOffset(Offset = "0x0")]
	private static ProtectorSettings setting;

	[Token(Token = "0x400F389")]
	public const float defaultDrawEffectIntensity = 0.3f;

	[Token(Token = "0x400F38A")]
	[FieldOffset(Offset = "0x18")]
	public List<Info> infoList;

	[Token(Token = "0x400F38B")]
	[FieldOffset(Offset = "0x20")]
	public float drawEffectIntensity;

	[Token(Token = "0x600AB91")]
	[Address(RVA = "0x429220", Offset = "0x428420", VA = "0x180429220")]
	public static void Load(Action<ProtectorSettings> onLoaded)
	{
	}

	[Token(Token = "0x600AB92")]
	[Address(RVA = "0x4290E0", Offset = "0x4282E0", VA = "0x1804290E0")]
	private Info GetInfoInternal(int protectorID)
	{
		return null;
	}

	[Token(Token = "0x600AB93")]
	[Address(RVA = "0x428B80", Offset = "0x427D80", VA = "0x180428B80")]
	private Info GetByIndexInternal(int index)
	{
		return null;
	}

	[Token(Token = "0x600AB94")]
	[Address(RVA = "0x428C00", Offset = "0x427E00", VA = "0x180428C00")]
	public static Info GetByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600AB95")]
	[Address(RVA = "0x428EF0", Offset = "0x4280F0", VA = "0x180428EF0")]
	private int GetIndexInternal(int protectorID)
	{
		return default(int);
	}

	[Token(Token = "0x600AB96")]
	[Address(RVA = "0x428FB0", Offset = "0x4281B0", VA = "0x180428FB0")]
	public static int GetIndex(int protectorID)
	{
		return default(int);
	}

	[Token(Token = "0x600AB97")]
	[Address(RVA = "0x428CF0", Offset = "0x427EF0", VA = "0x180428CF0")]
	private float GetDrawEffectIntensityInternal(int protectorID)
	{
		return default(float);
	}

	[Token(Token = "0x600AB98")]
	[Address(RVA = "0x428E40", Offset = "0x428040", VA = "0x180428E40")]
	public static float GetDrawEffectIntensity(int protectorID)
	{
		return default(float);
	}

	[Token(Token = "0x600AB99")]
	[Address(RVA = "0x4292F0", Offset = "0x4284F0", VA = "0x1804292F0")]
	private void SetIntensityInternal(int protectorID, float intensity)
	{
	}

	[Token(Token = "0x600AB9A")]
	[Address(RVA = "0x429410", Offset = "0x428610", VA = "0x180429410")]
	public static void SetIntensity(int protectorID, float intensity)
	{
	}

	[Token(Token = "0x600AB9B")]
	[Address(RVA = "0x4294C0", Offset = "0x4286C0", VA = "0x1804294C0")]
	public ProtectorSettings()
	{
	}
}
