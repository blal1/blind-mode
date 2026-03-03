using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200147F")]
public class ItemTransformSetting : ScriptableObject
{
	[Token(Token = "0x2001480")]
	public class OverrideValue<T>
	{
		[Token(Token = "0x400C6AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x6007F6F")]
		public OverrideValue([Optional] T value)
		{
		}

		[Token(Token = "0x6007F70")]
		public T TryGetValue(T defaultValue)
		{
			return (T)null;
		}
	}

	[Serializable]
	[Token(Token = "0x2001481")]
	public class OverrideVector3 : OverrideValue<Vector3>
	{
		[Token(Token = "0x6007F71")]
		[Address(RVA = "0xC784E0", Offset = "0xC776E0", VA = "0x180C784E0")]
		public OverrideVector3(Vector3 value)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001482")]
	public class OverrideTran
	{
		[Token(Token = "0x400C6AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400C6AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverrideVector3 position;

		[Token(Token = "0x400C6AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverrideVector3 scale;

		[Token(Token = "0x6007F72")]
		[Address(RVA = "0xC78360", Offset = "0xC77560", VA = "0x180C78360")]
		public OverrideTran()
		{
		}
	}

	[Token(Token = "0x400C6AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<OverrideTran> overrideTrans;

	[Token(Token = "0x6007F6C")]
	[Address(RVA = "0xC76420", Offset = "0xC75620", VA = "0x180C76420")]
	public OverrideTran Find([Optional] string label)
	{
		return null;
	}

	[Token(Token = "0x6007F6D")]
	[Address(RVA = "0xC76390", Offset = "0xC75590", VA = "0x180C76390")]
	public void Apply(RectTransform target, [Optional] string label)
	{
	}

	[Token(Token = "0x6007F6E")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public ItemTransformSetting()
	{
	}
}
