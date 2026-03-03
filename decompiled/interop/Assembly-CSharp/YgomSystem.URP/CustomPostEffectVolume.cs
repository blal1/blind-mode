using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace YgomSystem.URP;

[Serializable]
[Token(Token = "0x200031B")]
[VolumeComponentMenu("MDCustom Post-processing/CustomPostEffect")]
public class CustomPostEffectVolume : VolumeComponent
{
	[Token(Token = "0x4001100")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("m_PassName")]
	public StringParameter passName;

	[Token(Token = "0x4001101")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("m_Material")]
	public MaterialParameter material;

	[Token(Token = "0x4001102")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("m_PassIndex")]
	public IntParameter passIndex;

	[Token(Token = "0x4001103")]
	[FieldOffset(Offset = "0x50")]
	private string m_PassName_Blit_Cache;

	[Token(Token = "0x4001104")]
	[FieldOffset(Offset = "0x58")]
	private string m_PassName_Draw_Cache;

	[Token(Token = "0x170001EA")]
	public string passName_Blit
	{
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x405750", Offset = "0x404950", VA = "0x180405750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001EB")]
	public string passName_Draw
	{
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x4057E0", Offset = "0x4049E0", VA = "0x1804057E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001367")]
	[Address(RVA = "0x405630", Offset = "0x404830", VA = "0x180405630")]
	public CustomPostEffectVolume()
	{
	}
}
