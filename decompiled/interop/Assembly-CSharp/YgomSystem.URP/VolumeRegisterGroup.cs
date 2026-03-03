using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.URP;

[Token(Token = "0x2000315")]
public class VolumeRegisterGroup : MonoBehaviour
{
	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject s_RootGo;

	[Token(Token = "0x40010EE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera m_TargetCamera;

	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_DefaultRenderPostProcessing;

	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<VolumeRegister> m_Registers;

	[Token(Token = "0x6001345")]
	[Address(RVA = "0x41E490", Offset = "0x41D690", VA = "0x18041E490")]
	public static VolumeRegisterGroup FindOrCreateInstance(Camera targetCamera)
	{
		return null;
	}

	[Token(Token = "0x6001346")]
	[Address(RVA = "0x41E350", Offset = "0x41D550", VA = "0x18041E350")]
	public static VolumeRegisterGroup FindInstance(Camera targetCamera)
	{
		return null;
	}

	[Token(Token = "0x6001347")]
	[Address(RVA = "0x41E250", Offset = "0x41D450", VA = "0x18041E250")]
	public static void AssignRegister(Camera targetCamera, VolumeRegister setter)
	{
	}

	[Token(Token = "0x6001348")]
	[Address(RVA = "0x41E650", Offset = "0x41D850", VA = "0x18041E650")]
	private void OnAssignRegister(VolumeRegister setter)
	{
	}

	[Token(Token = "0x6001349")]
	[Address(RVA = "0x41EA30", Offset = "0x41DC30", VA = "0x18041EA30")]
	public static void RemoveRegister(Camera targetCamera, VolumeRegister setter)
	{
	}

	[Token(Token = "0x600134A")]
	[Address(RVA = "0x41E750", Offset = "0x41D950", VA = "0x18041E750")]
	private void OnRemoveRegister(VolumeRegister setter)
	{
	}

	[Token(Token = "0x600134B")]
	[Address(RVA = "0x41E740", Offset = "0x41D940", VA = "0x18041E740")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600134C")]
	[Address(RVA = "0x41E800", Offset = "0x41DA00", VA = "0x18041E800")]
	private void Release()
	{
	}

	[Token(Token = "0x600134D")]
	[Address(RVA = "0x41EB30", Offset = "0x41DD30", VA = "0x18041EB30")]
	public VolumeRegisterGroup()
	{
	}
}
