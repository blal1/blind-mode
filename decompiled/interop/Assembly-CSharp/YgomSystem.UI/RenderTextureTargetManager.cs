using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200045F")]
public class RenderTextureTargetManager : MonoBehaviour
{
	[Token(Token = "0x4001566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int targetCount;

	[Token(Token = "0x4001567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject lightObject;

	[Token(Token = "0x4001568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int idCount;

	[Token(Token = "0x4001569")]
	private const int maxId = 1000;

	[Token(Token = "0x400156A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HashSet<int> useIdxList;

	[Token(Token = "0x400156B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<int, int> usedPosDec;

	[Token(Token = "0x400156C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> removeIdxList;

	[Token(Token = "0x400156D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<RenderTextureTarget> renderTextureTargetList;

	[Token(Token = "0x400156E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _lightEnabled;

	[Token(Token = "0x400156F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderTextureTargetManager instance;

	[Token(Token = "0x4001570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool isQuitting;

	[Token(Token = "0x170002B8")]
	public static bool lightEnabled
	{
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x604090", Offset = "0x603290", VA = "0x180604090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x604110", Offset = "0x603310", VA = "0x180604110")]
		set
		{
		}
	}

	[Token(Token = "0x170002B9")]
	public static RenderTextureTargetManager Instance
	{
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x603E60", Offset = "0x603060", VA = "0x180603E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x603A90", Offset = "0x602C90", VA = "0x180603A90")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x603AD0", Offset = "0x602CD0", VA = "0x180603AD0")]
	public static void Reboot()
	{
	}

	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x603130", Offset = "0x602330", VA = "0x180603130")]
	public static void CreateManager()
	{
	}

	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x6032D0", Offset = "0x6024D0", VA = "0x1806032D0")]
	public static int Create(Action<RenderTextureTarget> onFinish, [Optional] Vector3? pos)
	{
		return default(int);
	}

	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x6034E0", Offset = "0x6026E0", VA = "0x1806034E0")]
	public static void DestroyTarget(int id)
	{
	}

	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x603800", Offset = "0x602A00", VA = "0x180603800")]
	public static Camera GetTargetCamera(int id)
	{
		return null;
	}

	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x6038F0", Offset = "0x602AF0", VA = "0x1806038F0")]
	private int GetUnusedId()
	{
		return default(int);
	}

	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x6039E0", Offset = "0x602BE0", VA = "0x1806039E0")]
	private int GetUnusedPos(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x603D10", Offset = "0x602F10", VA = "0x180603D10")]
	public RenderTextureTargetManager()
	{
	}
}
