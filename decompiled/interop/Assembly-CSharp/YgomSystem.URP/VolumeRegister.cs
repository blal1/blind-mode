using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using YgomSystem.Utility;

namespace YgomSystem.URP;

[Token(Token = "0x2000314")]
public class VolumeRegister : ComponentsRegisterBase<Volume>
{
	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("任意：直接描画カメラを指定する場合に設定")]
	private Camera m_RenderCamera;

	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0x30")]
	private int m_RegistedLayer;

	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0x38")]
	private Camera m_ResistedCamera;

	[Token(Token = "0x600133A")]
	[Address(RVA = "0x41F080", Offset = "0x41E280", VA = "0x18041F080")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600133B")]
	[Address(RVA = "0x41F120", Offset = "0x41E320", VA = "0x18041F120")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600133C")]
	[Address(RVA = "0x41F090", Offset = "0x41E290", VA = "0x18041F090")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600133D")]
	[Address(RVA = "0x41EFB0", Offset = "0x41E1B0", VA = "0x18041EFB0")]
	private bool IsNeedRegist()
	{
		return default(bool);
	}

	[Token(Token = "0x600133E")]
	[Address(RVA = "0x41F1B0", Offset = "0x41E3B0", VA = "0x18041F1B0")]
	private bool RegistIfNeeded()
	{
		return default(bool);
	}

	[Token(Token = "0x600133F")]
	[Address(RVA = "0x41F600", Offset = "0x41E800", VA = "0x18041F600")]
	private void Release(bool destroyVolumes)
	{
	}

	[Token(Token = "0x6001340")]
	[Address(RVA = "0x41F6C0", Offset = "0x41E8C0", VA = "0x18041F6C0")]
	private Camera TryGetRenderCamera()
	{
		return null;
	}

	[Token(Token = "0x6001341")]
	[Address(RVA = "0x41EBB0", Offset = "0x41DDB0", VA = "0x18041EBB0")]
	private void ActivateVolumes()
	{
	}

	[Token(Token = "0x6001342")]
	[Address(RVA = "0x41EEB0", Offset = "0x41E0B0", VA = "0x18041EEB0")]
	private void DeactivateVolumes()
	{
	}

	[Token(Token = "0x6001343")]
	[Address(RVA = "0x41F490", Offset = "0x41E690", VA = "0x18041F490")]
	private void ReleaseVolumes()
	{
	}

	[Token(Token = "0x6001344")]
	[Address(RVA = "0x41F720", Offset = "0x41E920", VA = "0x18041F720")]
	public VolumeRegister()
	{
	}
}
