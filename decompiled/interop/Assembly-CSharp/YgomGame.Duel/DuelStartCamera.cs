using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A36")]
public class DuelStartCamera : IMainCameraOperation
{
	[Token(Token = "0x400F20E")]
	[FieldOffset(Offset = "0x10")]
	private float time;

	[Token(Token = "0x17001A39")]
	public ChainedBezierMotion motion
	{
		[Token(Token = "0x600A9CF")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9D0")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600A9D1")]
	[Address(RVA = "0xF65250", Offset = "0xF64450", VA = "0x180F65250")]
	public DuelStartCamera(ChainedBezierMotion motion, Vector3 targetPosition, Quaternion targetRotation)
	{
	}

	[Token(Token = "0x600A9D2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public void LateUpdateOperation(MainCameraOrganizer mainCamera)
	{
	}

	[Token(Token = "0x600A9D3")]
	[Address(RVA = "0xF650F0", Offset = "0xF642F0", VA = "0x180F650F0", Slot = "4")]
	public void UpdateOperation(MainCameraOrganizer mainCamera)
	{
	}
}
