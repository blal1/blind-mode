using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Home;

[Token(Token = "0x200037D")]
[RequireComponent(typeof(BindingTopicsCardUV))]
public class ActiveTargetWithBindingTopicsCardUV : MonoBehaviour
{
	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> activeTrueObjects;

	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Transform> activeFalseObjects;

	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("trueならScaleを0にして見えなくさせます(処理負荷軽減のため)")]
	private bool isScaleZero;

	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x38")]
	protected BindingTopicsCardUV component;

	[Token(Token = "0x6001585")]
	[Address(RVA = "0x51AA50", Offset = "0x519C50", VA = "0x18051AA50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001586")]
	[Address(RVA = "0x51AAB0", Offset = "0x519CB0", VA = "0x18051AAB0")]
	private void UpdateActive()
	{
	}

	[Token(Token = "0x6001587")]
	[Address(RVA = "0x51AA40", Offset = "0x519C40", VA = "0x18051AA40")]
	public ActiveTargetWithBindingTopicsCardUV()
	{
	}
}
