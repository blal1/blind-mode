using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Download;

[Token(Token = "0x2000F68")]
public class DLCList
{
	[Serializable]
	[Token(Token = "0x2000F69")]
	public struct DLCInfo
	{
		[Token(Token = "0x400A80A")]
		[FieldOffset(Offset = "0x0")]
		public string assetName;

		[Token(Token = "0x400A80B")]
		[FieldOffset(Offset = "0x8")]
		public string version;

		[Token(Token = "0x400A80C")]
		[FieldOffset(Offset = "0x10")]
		public long bytes;

		[Token(Token = "0x400A80D")]
		[FieldOffset(Offset = "0x18")]
		public string crc;

		[Token(Token = "0x17000EBF")]
		public string path
		{
			[Token(Token = "0x6005D9B")]
			[Address(RVA = "0xA30760", Offset = "0xA2F960", VA = "0x180A30760")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x400A806")]
	public const string kFileName = "dlcList.json";

	[Token(Token = "0x400A807")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private List<DLCInfo> informations;

	[Token(Token = "0x400A809")]
	[FieldOffset(Offset = "0x0")]
	private static DLCList s_localList;

	[Token(Token = "0x17000EBD")]
	public Dictionary<string, DLCInfo> fileDict
	{
		[Token(Token = "0x6005D85")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005D86")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000EBE")]
	public int Count
	{
		[Token(Token = "0x6005D89")]
		[Address(RVA = "0xA31E00", Offset = "0xA31000", VA = "0x180A31E00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005D87")]
	[Address(RVA = "0xA31190", Offset = "0xA30390", VA = "0x180A31190")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6005D88")]
	[Address(RVA = "0xA308B0", Offset = "0xA2FAB0", VA = "0x180A308B0")]
	private void Clear()
	{
	}

	[Token(Token = "0x6005D8A")]
	[Address(RVA = "0xA30BF0", Offset = "0xA2FDF0", VA = "0x180A30BF0")]
	public List<string> GetAssetNames()
	{
		return null;
	}

	[Token(Token = "0x6005D8B")]
	[Address(RVA = "0xA30D20", Offset = "0xA2FF20", VA = "0x180A30D20")]
	public long GetBytes()
	{
		return default(long);
	}

	[Token(Token = "0x6005D8C")]
	[Address(RVA = "0xA31BC0", Offset = "0xA30DC0", VA = "0x180A31BC0")]
	public void Set(DLCInfo info)
	{
	}

	[Token(Token = "0x6005D8D")]
	[Address(RVA = "0xA31A20", Offset = "0xA30C20", VA = "0x180A31A20")]
	public void Remove(DLCInfo info)
	{
	}

	[Token(Token = "0x6005D8E")]
	[Address(RVA = "0xA31660", Offset = "0xA30860", VA = "0x180A31660")]
	public void Merge(DLCList merge)
	{
	}

	[Token(Token = "0x6005D8F")]
	[Address(RVA = "0xA30E40", Offset = "0xA30040", VA = "0x180A30E40")]
	public DLCList GetDiffList(DLCList target, bool versionCheck = true)
	{
		return null;
	}

	[Token(Token = "0x6005D90")]
	[Address(RVA = "0x936FA0", Offset = "0x9361A0", VA = "0x180936FA0")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x6005D91")]
	[Address(RVA = "0xA30B00", Offset = "0xA2FD00", VA = "0x180A30B00")]
	public bool Exists(string path, bool convertHash = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D92")]
	[Address(RVA = "0xA31110", Offset = "0xA30310", VA = "0x180A31110")]
	private static DLCList GetLocalInstance()
	{
		return null;
	}

	[Token(Token = "0x6005D93")]
	[Address(RVA = "0xA309C0", Offset = "0xA2FBC0", VA = "0x180A309C0")]
	public static bool ExistsLocalData(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6005D94")]
	[Address(RVA = "0xA307C0", Offset = "0xA2F9C0", VA = "0x180A307C0")]
	public static void ClearLocalInstance()
	{
	}

	[Token(Token = "0x6005D95")]
	[Address(RVA = "0xA31580", Offset = "0xA30780", VA = "0x180A31580")]
	public static DLCList Load()
	{
		return null;
	}

	[Token(Token = "0x6005D96")]
	[Address(RVA = "0xA31480", Offset = "0xA30680", VA = "0x180A31480")]
	public static DLCList LoadStreaming()
	{
		return null;
	}

	[Token(Token = "0x6005D97")]
	[Address(RVA = "0xA312C0", Offset = "0xA304C0", VA = "0x180A312C0")]
	public static DLCList LoadFromJson(string json)
	{
		return null;
	}

	[Token(Token = "0x6005D98")]
	[Address(RVA = "0xA31AB0", Offset = "0xA30CB0", VA = "0x180A31AB0")]
	public static void Save(DLCList target)
	{
	}

	[Token(Token = "0x6005D99")]
	[Address(RVA = "0xA30930", Offset = "0xA2FB30", VA = "0x180A30930")]
	public static void Delete()
	{
	}

	[Token(Token = "0x6005D9A")]
	[Address(RVA = "0xA31D40", Offset = "0xA30F40", VA = "0x180A31D40")]
	public DLCList()
	{
	}
}
