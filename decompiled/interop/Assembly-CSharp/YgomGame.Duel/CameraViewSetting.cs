using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001960")]
public class CameraViewSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001961")]
	public class ViewInfo
	{
		[Token(Token = "0x400EC28")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400EC29")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x400EC2A")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 angle;

		[Token(Token = "0x400EC2B")]
		[FieldOffset(Offset = "0x30")]
		public float fieldOfView;

		[Token(Token = "0x400EC2C")]
		[FieldOffset(Offset = "0x34")]
		public float nearClip;

		[Token(Token = "0x400EC2D")]
		[FieldOffset(Offset = "0x38")]
		public float farClip;

		[Token(Token = "0x170018F3")]
		public Quaternion rotation
		{
			[Token(Token = "0x600A310")]
			[Address(RVA = "0xF16D00", Offset = "0xF15F00", VA = "0x180F16D00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600A30F")]
		[Address(RVA = "0xF16C60", Offset = "0xF15E60", VA = "0x180F16C60")]
		public ViewInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600A311")]
		[Address(RVA = "0xF16CE0", Offset = "0xF15EE0", VA = "0x180F16CE0")]
		public ViewInfo()
		{
		}
	}

	[Token(Token = "0x400EC26")]
	[FieldOffset(Offset = "0x18")]
	public List<ViewInfo> infoList;

	[Token(Token = "0x400EC27")]
	[FieldOffset(Offset = "0x0")]
	public static CameraViewSetting _instance;

	[Token(Token = "0x170018F2")]
	private static CameraViewSetting instance
	{
		[Token(Token = "0x600A30C")]
		[Address(RVA = "0xF01640", Offset = "0xF00840", VA = "0x180F01640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A30B")]
	[Address(RVA = "0xF013C0", Offset = "0xF005C0", VA = "0x180F013C0")]
	public ViewInfo GetInfo(string label)
	{
		return null;
	}

	[Token(Token = "0x600A30D")]
	[Address(RVA = "0xF01490", Offset = "0xF00690", VA = "0x180F01490")]
	public static ViewInfo GetViewInfo(string label)
	{
		return null;
	}

	[Token(Token = "0x600A30E")]
	[Address(RVA = "0xF015C0", Offset = "0xF007C0", VA = "0x180F015C0")]
	public CameraViewSetting()
	{
	}
}
