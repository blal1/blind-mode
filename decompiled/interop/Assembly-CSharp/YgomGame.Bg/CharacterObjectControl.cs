using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D99")]
public class CharacterObjectControl : MonoBehaviour
{
	[Token(Token = "0x2001D9A")]
	public enum Type
	{
		[Token(Token = "0x401045E")]
		OnStateEnter,
		[Token(Token = "0x401045F")]
		ChangePreHide
	}

	[Serializable]
	[Token(Token = "0x2001D9B")]
	public class OnStateEnterControl
	{
		[Token(Token = "0x4010460")]
		[FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x4010461")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		[Token(Token = "0x4010462")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4010463")]
		[FieldOffset(Offset = "0x24")]
		public bool objectActive;

		[Token(Token = "0x4010464")]
		[FieldOffset(Offset = "0x25")]
		public bool rendererActive;

		[Token(Token = "0x4010465")]
		[FieldOffset(Offset = "0x28")]
		public List<GameObject> objectList;

		[Token(Token = "0x4010466")]
		[FieldOffset(Offset = "0x30")]
		public List<SkinnedMeshRenderer> rendererList;

		[Token(Token = "0x600BD88")]
		[Address(RVA = "0x58DFC0", Offset = "0x58D1C0", VA = "0x18058DFC0")]
		public OnStateEnterControl()
		{
		}
	}

	[Token(Token = "0x401045B")]
	[FieldOffset(Offset = "0x20")]
	public List<OnStateEnterControl> controlList;

	[Token(Token = "0x401045C")]
	[FieldOffset(Offset = "0x28")]
	private bool synced;

	[Token(Token = "0x17001C23")]
	public bool Synced
	{
		[Token(Token = "0x600BD85")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BD86")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		set
		{
		}
	}

	[Token(Token = "0x600BD87")]
	[Address(RVA = "0x588EE0", Offset = "0x5880E0", VA = "0x180588EE0")]
	public CharacterObjectControl()
	{
	}
}
