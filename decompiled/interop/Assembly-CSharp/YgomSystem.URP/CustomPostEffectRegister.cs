using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace YgomSystem.URP;

[Token(Token = "0x2000319")]
[ExecuteAlways]
public class CustomPostEffectRegister : MonoBehaviour
{
	[Token(Token = "0x40010FD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CustomPostEffectPass.Context m_Context;

	[Token(Token = "0x40010FE")]
	[FieldOffset(Offset = "0x28")]
	private int m_RegistedLayer;

	[Token(Token = "0x40010FF")]
	[FieldOffset(Offset = "0x30")]
	private CustomPostEffectPass m_Pass;

	[Token(Token = "0x170001E9")]
	public CustomPostEffectPass.Context context
	{
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600135D")]
	[Address(RVA = "0x405290", Offset = "0x404490", VA = "0x180405290")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600135E")]
	[Address(RVA = "0x405200", Offset = "0x404400", VA = "0x180405200")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600135F")]
	[Address(RVA = "0x405440", Offset = "0x404640", VA = "0x180405440")]
	private void SetupPass()
	{
	}

	[Token(Token = "0x6001360")]
	[Address(RVA = "0x405120", Offset = "0x404320", VA = "0x180405120")]
	private void OnBeginCamera(ScriptableRenderContext ctx, Camera cam)
	{
	}

	[Token(Token = "0x6001361")]
	[Address(RVA = "0x405010", Offset = "0x404210", VA = "0x180405010")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001362")]
	[Address(RVA = "0x405580", Offset = "0x404780", VA = "0x180405580")]
	public CustomPostEffectRegister()
	{
	}
}
