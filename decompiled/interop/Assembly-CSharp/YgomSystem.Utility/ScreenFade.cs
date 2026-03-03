using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003D4")]
public class ScreenFade : MonoBehaviour
{
	[Token(Token = "0x4001345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ScreenFade s_Instance;

	[Token(Token = "0x4001346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh m_screenMesh;

	[Token(Token = "0x4001347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color m_baseColor;

	[Token(Token = "0x4001348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color m_targetColor;

	[Token(Token = "0x4001349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material m_material;

	[Token(Token = "0x400134A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float m_timeMax;

	[Token(Token = "0x400134B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float m_timeCnt;

	[Token(Token = "0x400134C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float m_startDelay;

	[Token(Token = "0x400134D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_endDelay;

	[Token(Token = "0x400134E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float m_easingPow;

	[Token(Token = "0x400134F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool m_ignoreTimeScale;

	[Token(Token = "0x4001350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool m_inputEnable;

	[Token(Token = "0x4001351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	private bool m_autoDestroy;

	[Token(Token = "0x4001352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action m_onFinihed;

	[Token(Token = "0x4001353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<GraphicRaycaster> raycasterList;

	[Token(Token = "0x6001882")]
	[Address(RVA = "0x5C1AB0", Offset = "0x5C0CB0", VA = "0x1805C1AB0")]
	public static void FadeIn(float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, [Optional] Action onFinihed)
	{
	}

	[Token(Token = "0x6001883")]
	[Address(RVA = "0x5C1BC0", Offset = "0x5C0DC0", VA = "0x1805C1BC0")]
	public static void FadeOut(float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, [Optional] Action onFinihed)
	{
	}

	[Token(Token = "0x6001884")]
	[Address(RVA = "0x5C1910", Offset = "0x5C0B10", VA = "0x1805C1910")]
	public static void FadeColor(Color baseColor, Color targetColor, float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, [Optional] Action onFinihed)
	{
	}

	[Token(Token = "0x6001885")]
	[Address(RVA = "0x5C1A10", Offset = "0x5C0C10", VA = "0x1805C1A10")]
	public static void FadeEnd()
	{
	}

	[Token(Token = "0x6001886")]
	[Address(RVA = "0x5C12C0", Offset = "0x5C04C0", VA = "0x1805C12C0")]
	private static void CreateFade()
	{
	}

	[Token(Token = "0x6001887")]
	[Address(RVA = "0x5C10F0", Offset = "0x5C02F0", VA = "0x1805C10F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001888")]
	[Address(RVA = "0x5C2240", Offset = "0x5C1440", VA = "0x1805C2240")]
	private void Start()
	{
	}

	[Token(Token = "0x6001889")]
	[Address(RVA = "0x5C22F0", Offset = "0x5C14F0", VA = "0x1805C22F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600188A")]
	[Address(RVA = "0x5C1CD0", Offset = "0x5C0ED0", VA = "0x1805C1CD0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600188B")]
	[Address(RVA = "0x5C1D70", Offset = "0x5C0F70", VA = "0x1805C1D70")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x600188C")]
	[Address(RVA = "0x5C2090", Offset = "0x5C1290", VA = "0x1805C2090")]
	public void Play(Color baseColor, Color targetColor, float time, float startDelay = 0f, float endDelay = 0f, float easingPow = 1f, bool inputEnable = false, bool autoDestroy = true, bool ignoreTimeScale = false, [Optional] Action onFinihed)
	{
	}

	[Token(Token = "0x600188D")]
	[Address(RVA = "0x5C16D0", Offset = "0x5C08D0", VA = "0x1805C16D0")]
	private void DestroyFade()
	{
	}

	[Token(Token = "0x600188E")]
	[Address(RVA = "0x5C2120", Offset = "0x5C1320", VA = "0x1805C2120")]
	private void SetInputEnable(bool enable)
	{
	}

	[Token(Token = "0x600188F")]
	[Address(RVA = "0x5C13D0", Offset = "0x5C05D0", VA = "0x1805C13D0")]
	private Mesh CreateScreenMesh()
	{
		return null;
	}

	[Token(Token = "0x6001890")]
	[Address(RVA = "0x5C17B0", Offset = "0x5C09B0", VA = "0x1805C17B0")]
	private void DwarScreen(Material mat)
	{
	}

	[Token(Token = "0x6001891")]
	[Address(RVA = "0x5C2310", Offset = "0x5C1510", VA = "0x1805C2310")]
	public ScreenFade()
	{
	}
}
