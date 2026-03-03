using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001791")]
[CreateAssetMenu(menuName = "Scriptable Object/DuelEntryControllerSetting")]
public class DuelEntryControllerSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001792")]
	public class DuelEntryTimelineInfoEx
	{
		[Token(Token = "0x400DD51")]
		[FieldOffset(Offset = "0x10")]
		public int Logo_MixId;

		[Token(Token = "0x400DD52")]
		[FieldOffset(Offset = "0x18")]
		public string prefab_path;

		[Token(Token = "0x6009471")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DuelEntryTimelineInfoEx()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001793")]
	public struct RootPosBiasData
	{
		[Token(Token = "0x400DD53")]
		[FieldOffset(Offset = "0x0")]
		public float aspectRate;

		[Token(Token = "0x400DD54")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 rootPosBias;
	}

	[Token(Token = "0x400DD4C")]
	[FieldOffset(Offset = "0x18")]
	private int logo_MixId;

	[Token(Token = "0x400DD4D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DuelEntryTimelineInfoEx[] m_DuelEntryTimelineInfoExTable;

	[Token(Token = "0x400DD4E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public RootPosBiasData[] rootPosBiasDatas;

	[Token(Token = "0x400DD4F")]
	[FieldOffset(Offset = "0x0")]
	private static DuelEntryControllerSetting m_Instance;

	[Token(Token = "0x400DD50")]
	private const string PATH = "Duel/ScriptableObject/DuelEntryControllerSetting";

	[Token(Token = "0x170016A8")]
	protected static DuelEntryControllerSetting Instance
	{
		[Token(Token = "0x600946A")]
		[Address(RVA = "0xDDDAC0", Offset = "0xDDCCC0", VA = "0x180DDDAC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600946B")]
	[Address(RVA = "0xDDD6B0", Offset = "0xDDC8B0", VA = "0x180DDD6B0")]
	public static (bool, string) GetTimelineExInfo(int logo_mixid)
	{
		return default((bool, string));
	}

	[Token(Token = "0x600946C")]
	[Address(RVA = "0xDDD5B0", Offset = "0xDDC7B0", VA = "0x180DDD5B0")]
	public static Vector3 GetDuelEntryDistanceBias(float aspectRate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600946D")]
	[Address(RVA = "0xDDD9E0", Offset = "0xDDCBE0", VA = "0x180DDD9E0")]
	public static void UpdateLogoMixedId()
	{
	}

	[Token(Token = "0x600946E")]
	[Address(RVA = "0xDDD690", Offset = "0xDDC890", VA = "0x180DDD690")]
	public static int GetLogoMixid()
	{
		return default(int);
	}

	[Token(Token = "0x600946F")]
	[Address(RVA = "0xDDD770", Offset = "0xDDC970", VA = "0x180DDD770")]
	public void PlayWcsLogoEvent()
	{
	}

	[Token(Token = "0x6009470")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public DuelEntryControllerSetting()
	{
	}
}
