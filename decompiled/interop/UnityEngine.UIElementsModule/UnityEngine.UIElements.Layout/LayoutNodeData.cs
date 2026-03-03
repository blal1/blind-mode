using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005A0")]
internal struct LayoutNodeData
{
	[Token(Token = "0x20005A1")]
	[Flags]
	internal enum FlexStatus
	{
		[Token(Token = "0x4001428")]
		IsDirty = 1,
		[Token(Token = "0x4001429")]
		HasNewLayout = 4,
		[Token(Token = "0x400142A")]
		DependsOnParentSize = 0x40,
		[Token(Token = "0x400142B")]
		Fixed = 8,
		[Token(Token = "0x400142C")]
		MinViolation = 0x10,
		[Token(Token = "0x400142D")]
		MaxViolation = 0x20
	}

	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0x0")]
	public FixedBuffer2<LayoutValue> ResolvedDimensions;

	[Token(Token = "0x400141D")]
	[FieldOffset(Offset = "0x10")]
	private float TargetSize;

	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0x14")]
	public int ManagedMeasureFunctionIndex;

	[Token(Token = "0x400141F")]
	[FieldOffset(Offset = "0x18")]
	public int ManagedBaselineFunctionIndex;

	[Token(Token = "0x4001420")]
	[FieldOffset(Offset = "0x1C")]
	public int ManagedOwnerIndex;

	[Token(Token = "0x4001421")]
	[FieldOffset(Offset = "0x20")]
	public int LineIndex;

	[Token(Token = "0x4001422")]
	[FieldOffset(Offset = "0x24")]
	public LayoutHandle Config;

	[Token(Token = "0x4001423")]
	[FieldOffset(Offset = "0x2C")]
	public LayoutHandle Parent;

	[Token(Token = "0x4001424")]
	[FieldOffset(Offset = "0x34")]
	public LayoutHandle NextChild;

	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0x40")]
	public LayoutList<LayoutHandle> Children;

	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x50")]
	private FlexStatus Status;

	[Token(Token = "0x17000A1B")]
	public bool HasNewLayout
	{
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x29D4C40", Offset = "0x29D3E40", VA = "0x1829D4C40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x2A714F0", Offset = "0x2A706F0", VA = "0x182A714F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A1C")]
	public bool IsDirty
	{
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x1E39330", Offset = "0x1E38530", VA = "0x181E39330")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x2A71510", Offset = "0x2A70710", VA = "0x182A71510")]
		set
		{
		}
	}
}
