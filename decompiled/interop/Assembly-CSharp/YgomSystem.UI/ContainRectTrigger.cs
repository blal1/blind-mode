using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000464")]
public class ContainRectTrigger : MonoBehaviour
{
	[Token(Token = "0x4001577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform m_Container;

	[Token(Token = "0x4001578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform m_Target;

	[Token(Token = "0x170002BA")]
	public bool isContain
	{
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000019")]
	public event Action<bool> onChangeEvent
	{
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x5FDE00", Offset = "0x5FD000", VA = "0x1805FDE00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0x5FDEB0", Offset = "0x5FD0B0", VA = "0x1805FDEB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x5FD930", Offset = "0x5FCB30", VA = "0x1805FD930")]
	public static ContainRectTrigger Attach(RectTransform target, RectTransform container, [Optional] Action<bool> onChangeCallback)
	{
		return null;
	}

	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x5FDDF0", Offset = "0x5FCFF0", VA = "0x1805FDDF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x5FDC10", Offset = "0x5FCE10", VA = "0x1805FDC10")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x5FDA70", Offset = "0x5FCC70", VA = "0x1805FDA70")]
	private bool IsInViewport()
	{
		return default(bool);
	}

	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ContainRectTrigger()
	{
	}
}
