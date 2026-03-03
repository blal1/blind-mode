using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A3D")]
[CreateAssetMenu(menuName = "Scriptable Object/FusionEffectSetting")]
public class FusionEffectSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001A3E")]
	public class FusionEffectInfo
	{
		[Token(Token = "0x400F23B")]
		[FieldOffset(Offset = "0x10")]
		public FusionEffect.FusionType fusionType;

		[Token(Token = "0x400F23C")]
		[FieldOffset(Offset = "0x14")]
		public int mrk;

		[Token(Token = "0x400F23D")]
		[FieldOffset(Offset = "0x18")]
		public string comment;

		[Token(Token = "0x600AA02")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FusionEffectInfo()
		{
		}
	}

	[Token(Token = "0x400F232")]
	private const string settingPath = "Duel/ScriptableObject/FusionEffectSetting";

	[Token(Token = "0x400F233")]
	[FieldOffset(Offset = "0x18")]
	public string basePath;

	[Token(Token = "0x400F234")]
	[FieldOffset(Offset = "0x20")]
	public string showBasePath;

	[Token(Token = "0x400F235")]
	[FieldOffset(Offset = "0x28")]
	public string partsBasePath;

	[Token(Token = "0x400F236")]
	[FieldOffset(Offset = "0x30")]
	public string baseNumPath;

	[Token(Token = "0x400F237")]
	[FieldOffset(Offset = "0x38")]
	public string bgPath;

	[Token(Token = "0x400F238")]
	[FieldOffset(Offset = "0x40")]
	public List<FusionEffectInfo> fusionEffectInfos;

	[Token(Token = "0x400F239")]
	[FieldOffset(Offset = "0x48")]
	public List<int> exceptionMaterialNum;

	[Token(Token = "0x400F23A")]
	[FieldOffset(Offset = "0x0")]
	private static FusionEffectSetting m_Instance;

	[Token(Token = "0x17001A3E")]
	public static FusionEffectSetting Instance
	{
		[Token(Token = "0x600A9F9")]
		[Address(RVA = "0xF67400", Offset = "0xF66600", VA = "0x180F67400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A9FA")]
	[Address(RVA = "0xF66EE0", Offset = "0xF660E0", VA = "0x180F66EE0")]
	public int GetMrk(FusionEffect.FusionType fusionType)
	{
		return default(int);
	}

	[Token(Token = "0x600A9FB")]
	[Address(RVA = "0xF66E10", Offset = "0xF66010", VA = "0x180F66E10")]
	public FusionEffect.FusionType GetFusionType(int mrk)
	{
		return default(FusionEffect.FusionType);
	}

	[Token(Token = "0x600A9FC")]
	[Address(RVA = "0xF670A0", Offset = "0xF662A0", VA = "0x180F670A0")]
	public string GetPath(int num)
	{
		return null;
	}

	[Token(Token = "0x600A9FD")]
	[Address(RVA = "0xF67110", Offset = "0xF66310", VA = "0x180F67110")]
	public string GetShowPath(int mrk, int num)
	{
		return null;
	}

	[Token(Token = "0x600A9FE")]
	[Address(RVA = "0xF66FB0", Offset = "0xF661B0", VA = "0x180F66FB0")]
	public string GetPartsPath(int mrk, int num)
	{
		return null;
	}

	[Token(Token = "0x600A9FF")]
	[Address(RVA = "0xF66D80", Offset = "0xF65F80", VA = "0x180F66D80")]
	public string GetBgPath(int num)
	{
		return null;
	}

	[Token(Token = "0x600AA00")]
	[Address(RVA = "0xF67290", Offset = "0xF66490", VA = "0x180F67290")]
	public bool IsExceptionMaterialNum(int num)
	{
		return default(bool);
	}

	[Token(Token = "0x600AA01")]
	[Address(RVA = "0xF67340", Offset = "0xF66540", VA = "0x180F67340")]
	public FusionEffectSetting()
	{
	}
}
