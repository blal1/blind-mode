using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Solo;

namespace YgomGame.Menu.Common;

[Token(Token = "0x20014A3")]
public class SoloResourceBinder : ResourceBinderBase
{
	[Serializable]
	[Token(Token = "0x20014A4")]
	public class SoloPathData
	{
		[Token(Token = "0x400C730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_CardThumbSettingPath;

		[Token(Token = "0x400C731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_GateTexPath_L;

		[Token(Token = "0x400C732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string m_GateTexPath_S;

		[Token(Token = "0x400C733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string m_ChapterTexPath;

		[Token(Token = "0x6008013")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SoloPathData()
		{
		}
	}

	[Token(Token = "0x400C72D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private SoloCardThumbSettings m_CardThumbSettings;

	[Token(Token = "0x400C72E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_CardThumbRefCount;

	[Token(Token = "0x400C72F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SoloPathData m_PathData;

	[Token(Token = "0x6008005")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void Initialize(SoloPathData pathData)
	{
	}

	[Token(Token = "0x6008006")]
	[Address(RVA = "0xC7E4B0", Offset = "0xC7D6B0", VA = "0x180C7E4B0")]
	public void LoadCardThumbSettings()
	{
	}

	[Token(Token = "0x6008007")]
	[Address(RVA = "0xC7E570", Offset = "0xC7D770", VA = "0x180C7E570")]
	public void UnloadCardThumbSettings()
	{
	}

	[Token(Token = "0x6008008")]
	[Address(RVA = "0xC7E5A0", Offset = "0xC7D7A0", VA = "0x180C7E5A0")]
	public void UnloadForce()
	{
	}

	[Token(Token = "0x6008009")]
	[Address(RVA = "0xC7E300", Offset = "0xC7D500", VA = "0x180C7E300")]
	public string GetSoloCardThumbDataPath()
	{
		return null;
	}

	[Token(Token = "0x600800A")]
	[Address(RVA = "0xC7E320", Offset = "0xC7D520", VA = "0x180C7E320")]
	public string GetSoloGateTexPathLarge()
	{
		return null;
	}

	[Token(Token = "0x600800B")]
	[Address(RVA = "0x571A60", Offset = "0x570C60", VA = "0x180571A60")]
	public string GetSoloGateTexPathSmall()
	{
		return null;
	}

	[Token(Token = "0x600800C")]
	[Address(RVA = "0x697FB0", Offset = "0x6971B0", VA = "0x180697FB0")]
	public string GetSoloChapterTexPath()
	{
		return null;
	}

	[Token(Token = "0x600800D")]
	[Address(RVA = "0xC7E340", Offset = "0xC7D540", VA = "0x180C7E340")]
	public int GetSoloMrk(SoloCardThumbSettings.Format format, int id, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x600800E")]
	[Address(RVA = "0xC7E410", Offset = "0xC7D610", VA = "0x180C7E410")]
	public bool IsExistSetting(SoloCardThumbSettings.Format format, int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600800F")]
	[Address(RVA = "0xC7E240", Offset = "0xC7D440", VA = "0x180C7E240")]
	public BindingSoloCardThumb BindCardThumb(RectTransform target, int id, SoloCardThumbSettings.Format thumbFormat, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008010")]
	[Address(RVA = "0xC7E180", Offset = "0xC7D380", VA = "0x180C7E180")]
	public BindingSoloCardThumb BindCardThumbOther(RectTransform target, int id, SoloCardThumbSettings.Format thumbFormat, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008011")]
	[Address(RVA = "0xC7E020", Offset = "0xC7D220", VA = "0x180C7E020")]
	public BindingSoloCardThumb BindCardThumbLootSource(RectTransform target, int id, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008012")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SoloResourceBinder()
	{
	}
}
