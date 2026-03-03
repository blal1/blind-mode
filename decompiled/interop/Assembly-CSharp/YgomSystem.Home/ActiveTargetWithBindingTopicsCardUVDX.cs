using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Home;

[Token(Token = "0x200037E")]
[RequireComponent(typeof(BindingTopicsCardUVDX))]
public class ActiveTargetWithBindingTopicsCardUVDX : MonoBehaviour
{
	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> activeTrueObjects;

	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Transform> activeFalseObjects;

	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("trueならScaleを0にして見えなくさせます(処理負荷軽減のため)")]
	private bool isScaleZero;

	[Token(Token = "0x40011F4")]
	[FieldOffset(Offset = "0x38")]
	protected BindingTopicsCardUVDX component;

	[Token(Token = "0x6001588")]
	[Address(RVA = "0x51A0C0", Offset = "0x5192C0", VA = "0x18051A0C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001589")]
	[Address(RVA = "0x51A120", Offset = "0x519320", VA = "0x18051A120")]
	private void UpdateActive()
	{
	}

	[Token(Token = "0x600158A")]
	[Address(RVA = "0x51AA40", Offset = "0x519C40", VA = "0x18051AA40")]
	public ActiveTargetWithBindingTopicsCardUVDX()
	{
	}
}
