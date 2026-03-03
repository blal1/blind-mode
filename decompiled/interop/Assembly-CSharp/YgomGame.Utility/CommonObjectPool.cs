using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x2000918")]
public class CommonObjectPool : MonoBehaviour
{
	[Token(Token = "0x2000919")]
	private class PoolInfo
	{
		[Token(Token = "0x4008999")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400899A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x600369D")]
		[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
		public PoolInfo(string label, GameObject gameObject)
		{
		}
	}

	[Token(Token = "0x4008997")]
	[FieldOffset(Offset = "0x0")]
	private static CommonObjectPool _instance;

	[Token(Token = "0x4008998")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, List<PoolInfo>> pool;

	[Token(Token = "0x1700068B")]
	private static CommonObjectPool instance
	{
		[Token(Token = "0x6003695")]
		[Address(RVA = "0x7B97B0", Offset = "0x7B89B0", VA = "0x1807B97B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003696")]
	[Address(RVA = "0x7B94D0", Offset = "0x7B86D0", VA = "0x1807B94D0")]
	private void Push(string group, string label, GameObject target, bool setInactivate)
	{
	}

	[Token(Token = "0x6003697")]
	[Address(RVA = "0x7B9240", Offset = "0x7B8440", VA = "0x1807B9240")]
	private GameObject Pop(string group, string label, Transform parent, bool setAcvtive)
	{
		return null;
	}

	[Token(Token = "0x6003698")]
	[Address(RVA = "0x7B8EA0", Offset = "0x7B80A0", VA = "0x1807B8EA0")]
	private void ClearGroup(string group)
	{
	}

	[Token(Token = "0x6003699")]
	[Address(RVA = "0x7B9410", Offset = "0x7B8610", VA = "0x1807B9410")]
	public static void PushPool(string group, string label, GameObject target, bool setActive = true)
	{
	}

	[Token(Token = "0x600369A")]
	[Address(RVA = "0x7B9180", Offset = "0x7B8380", VA = "0x1807B9180")]
	public static GameObject PopPool(string group, string label, Transform parent, bool setInactive = true)
	{
		return null;
	}

	[Token(Token = "0x600369B")]
	[Address(RVA = "0x7B8FE0", Offset = "0x7B81E0", VA = "0x1807B8FE0")]
	public static void ClearPoolGroup(string group)
	{
	}

	[Token(Token = "0x600369C")]
	[Address(RVA = "0x7B9730", Offset = "0x7B8930", VA = "0x1807B9730")]
	public CommonObjectPool()
	{
	}
}
