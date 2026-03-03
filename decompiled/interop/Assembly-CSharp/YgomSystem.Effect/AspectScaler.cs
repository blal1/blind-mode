using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Effect;

[Token(Token = "0x200031D")]
public class AspectScaler : MonoBehaviour
{
	[Token(Token = "0x4001105")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool applyOnUpdate;

	[Token(Token = "0x4001106")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float aspect;

	[Token(Token = "0x170001EC")]
	public Camera viewCamera
	{
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600136B")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void Setup(Camera view_camera)
	{
	}

	[Token(Token = "0x600136C")]
	[Address(RVA = "0x402EA0", Offset = "0x4020A0", VA = "0x180402EA0")]
	public void Apply()
	{
	}

	[Token(Token = "0x600136D")]
	[Address(RVA = "0x402FC0", Offset = "0x4021C0", VA = "0x180402FC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600136E")]
	[Address(RVA = "0x4030E0", Offset = "0x4022E0", VA = "0x1804030E0")]
	public AspectScaler()
	{
	}
}
