using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x200041C")]
internal class TweenConductor : MonoBehaviour
{
	[Token(Token = "0x400143F")]
	[FieldOffset(Offset = "0x20")]
	public bool playOnStart;

	[Token(Token = "0x4001440")]
	[FieldOffset(Offset = "0x21")]
	public bool destroyOnFinished;

	[Token(Token = "0x4001441")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject target;

	[Token(Token = "0x4001442")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<string> labelList;

	[Token(Token = "0x4001443")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent<string> onStarted;

	[Token(Token = "0x4001444")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent<string> onFinished;

	[Token(Token = "0x4001445")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent onCompleted;

	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0x50")]
	private bool playing;

	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0x54")]
	private int currentLabelIndex;

	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x58")]
	private string currentLabel;

	[Token(Token = "0x4001449")]
	[FieldOffset(Offset = "0x60")]
	private List<Tween> tweens;

	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x5F1650", Offset = "0x5F0850", VA = "0x1805F1650")]
	public static TweenConductor Create(GameObject addComponentTarget, GameObject target, List<string> labelList, UnityAction<string> onStarted, UnityAction<string> onFinished, UnityAction onCompleted)
	{
		return null;
	}

	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x5F1A50", Offset = "0x5F0C50", VA = "0x1805F1A50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x5F1CC0", Offset = "0x5F0EC0", VA = "0x1805F1CC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x5F1AD0", Offset = "0x5F0CD0", VA = "0x1805F1AD0")]
	public void PlayStart()
	{
	}

	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x5F1D50", Offset = "0x5F0F50", VA = "0x1805F1D50")]
	private void Update()
	{
	}

	[Token(Token = "0x6001A88")]
	[Address(RVA = "0x5F18B0", Offset = "0x5F0AB0", VA = "0x1805F18B0")]
	private bool IsPlaying(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x5F1B50", Offset = "0x5F0D50", VA = "0x1805F1B50")]
	private void Play(string label)
	{
	}

	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x5F1EA0", Offset = "0x5F10A0", VA = "0x1805F1EA0")]
	public TweenConductor()
	{
	}
}
