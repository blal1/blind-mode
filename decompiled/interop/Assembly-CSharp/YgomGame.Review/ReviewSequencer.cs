using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Review;

[Token(Token = "0x2000B35")]
public class ReviewSequencer : MonoBehaviour
{
	[Token(Token = "0x40095DD")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ReviewEntryDialogUIPrefPath;

	[Token(Token = "0x40095DE")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_SelectEnqueteOrSuportPrefPath;

	[Token(Token = "0x40095DF")]
	[FieldOffset(Offset = "0x30")]
	private IReadOnlyDictionary<string, object> m_ReviewData;

	[Token(Token = "0x40095E0")]
	[FieldOffset(Offset = "0x38")]
	private int m_EnqueteId;

	[Token(Token = "0x40095E1")]
	[FieldOffset(Offset = "0x40")]
	private string m_ReviewURL;

	[Token(Token = "0x40095E2")]
	[FieldOffset(Offset = "0x48")]
	private Action m_Callback;

	[Token(Token = "0x40095E3")]
	[FieldOffset(Offset = "0x50")]
	private ViewController m_RootContent;

	[Token(Token = "0x40095E4")]
	[FieldOffset(Offset = "0x58")]
	private ViewController m_RootDialog;

	[Token(Token = "0x6004491")]
	[Address(RVA = "0x8F1000", Offset = "0x8F0200", VA = "0x1808F1000")]
	public static void Launch(IReadOnlyDictionary<string, object> reviewData, Action callback)
	{
	}

	[Token(Token = "0x6004492")]
	[Address(RVA = "0x8F1120", Offset = "0x8F0320", VA = "0x1808F1120")]
	private void Start()
	{
	}

	[Token(Token = "0x6004493")]
	[Address(RVA = "0x8F22E0", Offset = "0x8F14E0", VA = "0x1808F22E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6004494")]
	[Address(RVA = "0x8F10C0", Offset = "0x8F02C0", VA = "0x1808F10C0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004495")]
	[Address(RVA = "0x8F1E30", Offset = "0x8F1030", VA = "0x1808F1E30")]
	private void ToReview()
	{
	}

	[Token(Token = "0x6004496")]
	[Address(RVA = "0x8F1EA0", Offset = "0x8F10A0", VA = "0x1808F1EA0")]
	private void ToSelectEnqueteOrSupport()
	{
	}

	[Token(Token = "0x6004497")]
	[Address(RVA = "0x8F1BB0", Offset = "0x8F0DB0", VA = "0x1808F1BB0")]
	private void ToEnquete()
	{
	}

	[Token(Token = "0x6004498")]
	[Address(RVA = "0x8F1FD0", Offset = "0x8F11D0", VA = "0x1808F1FD0")]
	private void ToSupport()
	{
	}

	[Token(Token = "0x6004499")]
	[Address(RVA = "0x8F18D0", Offset = "0x8F0AD0", VA = "0x1808F18D0")]
	private void ToCompleteAnswer()
	{
	}

	[Token(Token = "0x600449A")]
	[Address(RVA = "0x8F1D10", Offset = "0x8F0F10", VA = "0x1808F1D10")]
	private void ToFinish()
	{
	}

	[Token(Token = "0x600449B")]
	[Address(RVA = "0x8F2370", Offset = "0x8F1570", VA = "0x1808F2370")]
	public ReviewSequencer()
	{
	}
}
