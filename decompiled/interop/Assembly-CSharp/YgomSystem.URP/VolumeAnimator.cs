using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace YgomSystem.URP;

[Token(Token = "0x2000311")]
[ExecuteAlways]
[RequireComponent(typeof(Volume))]
public class VolumeAnimator : MonoBehaviour
{
	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x20")]
	private Volume m_VolumeCache;

	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x28")]
	private List<IVolumeAnimatorComponent> m_AnimateCompoentsCache;

	[Token(Token = "0x170001E2")]
	public Volume volume
	{
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x41E1C0", Offset = "0x41D3C0", VA = "0x18041E1C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E3")]
	private List<IVolumeAnimatorComponent> animateCompoents
	{
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x41E190", Offset = "0x41D390", VA = "0x18041E190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001320")]
	[Address(RVA = "0x41E0A0", Offset = "0x41D2A0", VA = "0x18041E0A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x41E090", Offset = "0x41D290", VA = "0x18041E090")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0x41E0A0", Offset = "0x41D2A0", VA = "0x18041E0A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001323")]
	[Address(RVA = "0x41DD10", Offset = "0x41CF10", VA = "0x18041DD10")]
	public void Export()
	{
	}

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x41DED0", Offset = "0x41D0D0", VA = "0x18041DED0")]
	public void Import()
	{
	}

	[Token(Token = "0x6001325")]
	[Address(RVA = "0x41D9A0", Offset = "0x41CBA0", VA = "0x18041D9A0")]
	public void Bind(bool avoidInstance = false)
	{
	}

	[Token(Token = "0x6001326")]
	[Address(RVA = "0x41E0B0", Offset = "0x41D2B0", VA = "0x18041E0B0")]
	public void ReleaseProfileInstance()
	{
	}

	[Token(Token = "0x6001327")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public VolumeAnimator()
	{
	}
}
