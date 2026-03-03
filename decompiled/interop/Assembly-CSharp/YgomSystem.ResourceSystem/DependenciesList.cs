using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x200029F")]
public class DependenciesList
{
	[Serializable]
	[Token(Token = "0x20002A0")]
	public class DependenciesInfo
	{
		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x10")]
		public string assetName;

		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x18")]
		public string[] dependencies;

		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x696B90", Offset = "0x695D90", VA = "0x180696B90")]
		public DependenciesInfo()
		{
		}
	}

	[Token(Token = "0x4000EE1")]
	private const string kManifestFileName = "manifest";

	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private List<DependenciesInfo> informations;

	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, DependenciesInfo> dictionary;

	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0xE6D310", Offset = "0xE6C510", VA = "0x180E6D310")]
	public static string GetFileNameForCommon()
	{
		return null;
	}

	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0xE6D3A0", Offset = "0xE6C5A0", VA = "0x180E6D3A0")]
	public static string GetFileNameForLanguage()
	{
		return null;
	}

	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0xE6D270", Offset = "0xE6C470", VA = "0x180E6D270")]
	public static string GetFileNameForCardIllust()
	{
		return null;
	}

	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0xE6D440", Offset = "0xE6C640", VA = "0x180E6D440")]
	public static string GetFileNameForStreamingData()
	{
		return null;
	}

	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0xE6D4D0", Offset = "0xE6C6D0", VA = "0x180E6D4D0")]
	public static string GetFileName(string lang)
	{
		return null;
	}

	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0xE6DEB0", Offset = "0xE6D0B0", VA = "0x180E6DEB0")]
	public static DependenciesList Load()
	{
		return null;
	}

	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0xE6D670", Offset = "0xE6C870", VA = "0x180E6D670")]
	private static DependenciesList LoadBaseData()
	{
		return null;
	}

	[Token(Token = "0x6000FED")]
	[Address(RVA = "0xE6D7B0", Offset = "0xE6C9B0", VA = "0x180E6D7B0")]
	private static DependenciesList LoadLanguageData()
	{
		return null;
	}

	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0xE6D710", Offset = "0xE6C910", VA = "0x180E6D710")]
	private static DependenciesList LoadCardIllustData()
	{
		return null;
	}

	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0xE6DB40", Offset = "0xE6CD40", VA = "0x180E6DB40")]
	public static DependenciesList LoadStreaming()
	{
		return null;
	}

	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0xE6D850", Offset = "0xE6CA50", VA = "0x180E6D850")]
	private static DependenciesList LoadStreamingBaseData()
	{
		return null;
	}

	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0xE6DA00", Offset = "0xE6CC00", VA = "0x180E6DA00")]
	private static DependenciesList LoadStreamingCommonData()
	{
		return null;
	}

	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0xE6DAA0", Offset = "0xE6CCA0", VA = "0x180E6DAA0")]
	private static DependenciesList LoadStreamingLangData()
	{
		return null;
	}

	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0xE6D960", Offset = "0xE6CB60", VA = "0x180E6D960")]
	private static DependenciesList LoadStreamingCardIllustData()
	{
		return null;
	}

	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0xE6D070", Offset = "0xE6C270", VA = "0x180E6D070")]
	private static DependenciesList EncryptFromBytes(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0xE6D540", Offset = "0xE6C740", VA = "0x180E6D540")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0xE6D1E0", Offset = "0xE6C3E0", VA = "0x180E6D1E0")]
	public string[] GetDependencies(string assetName)
	{
		return null;
	}

	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0xE6D180", Offset = "0xE6C380", VA = "0x180E6D180")]
	public bool Exist(string assetName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0xE6E110", Offset = "0xE6D310", VA = "0x180E6E110")]
	public void Merge(DependenciesList target)
	{
	}

	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0xE6CFF0", Offset = "0xE6C1F0", VA = "0x180E6CFF0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0xE6E370", Offset = "0xE6D570", VA = "0x180E6E370")]
	public DependenciesList()
	{
	}
}
