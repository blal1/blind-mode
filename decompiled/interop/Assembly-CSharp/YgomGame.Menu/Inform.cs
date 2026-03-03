using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x20011A1")]
public class Inform : MonoBehaviour
{
	[Token(Token = "0x20011A2")]
	public enum PrefType
	{
		[Token(Token = "0x400B852")]
		Toast
	}

	[Token(Token = "0x400B84E")]
	[FieldOffset(Offset = "0x0")]
	private static Inform s_Instance;

	[Token(Token = "0x400B84F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ToastMessageInform m_ToastPref;

	[Token(Token = "0x400B850")]
	[FieldOffset(Offset = "0x28")]
	private List<InformContentBase> m_SearchContentList;

	[Token(Token = "0x1700116C")]
	public static Inform Instance
	{
		[Token(Token = "0x6006EB5")]
		[Address(RVA = "0xB602F0", Offset = "0xB5F4F0", VA = "0x180B602F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006EB6")]
	[Address(RVA = "0xB5FD50", Offset = "0xB5EF50", VA = "0x180B5FD50")]
	private InformContentBase GetPref(PrefType prefType)
	{
		return null;
	}

	[Token(Token = "0x6006EB7")]
	[Address(RVA = "0xB5FCF0", Offset = "0xB5EEF0", VA = "0x180B5FCF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006EB8")]
	[Address(RVA = "0xB5FD60", Offset = "0xB5EF60", VA = "0x180B5FD60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006EB9")]
	[Address(RVA = "0xB5FE00", Offset = "0xB5F000", VA = "0x180B5FE00")]
	public static void Push(PrefType prefType, Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006EBA")]
	[Address(RVA = "0xB5FF20", Offset = "0xB5F120", VA = "0x180B5FF20")]
	public static IReadOnlyList<InformContentBase> SearchContents()
	{
		return null;
	}

	[Token(Token = "0x6006EBB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public Inform()
	{
	}
}
