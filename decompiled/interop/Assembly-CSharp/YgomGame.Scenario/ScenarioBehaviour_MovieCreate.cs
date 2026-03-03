using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Movie;
using YgomGame.Settings;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AA4")]
public class ScenarioBehaviour_MovieCreate : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour, IScenarioLoadGroupHandleBehaviour
{
	[Token(Token = "0x4009328")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_CreatedObj;

	[Token(Token = "0x4009329")]
	[FieldOffset(Offset = "0x58")]
	private MovieWidget m_MovieWidget;

	[Token(Token = "0x400932A")]
	[FieldOffset(Offset = "0x60")]
	private int m_InnerStep;

	[Token(Token = "0x400932B")]
	[FieldOffset(Offset = "0x64")]
	private float movieLength;

	[Token(Token = "0x400932C")]
	[FieldOffset(Offset = "0x68")]
	private bool isLoading;

	[Token(Token = "0x400932D")]
	[FieldOffset(Offset = "0x69")]
	private bool isOpenDisconnectDialog;

	[Token(Token = "0x400932E")]
	[FieldOffset(Offset = "0x70")]
	private FrameMarkAsset m_FrameMarkAsset;

	[Token(Token = "0x400932F")]
	[FieldOffset(Offset = "0x78")]
	private float m_BaseVolume;

	[Token(Token = "0x4009330")]
	[FieldOffset(Offset = "0x7C")]
	private SettingsUtil.SoundParam m_SoundParam;

	[Token(Token = "0x600414F")]
	[Address(RVA = "0x883730", Offset = "0x882930", VA = "0x180883730")]
	public ScenarioBehaviour_MovieCreate(object commandData)
	{
	}

	[Token(Token = "0x6004150")]
	[Address(RVA = "0x8815A0", Offset = "0x8807A0", VA = "0x1808815A0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004151")]
	[Address(RVA = "0x8828E0", Offset = "0x881AE0", VA = "0x1808828E0", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6004152")]
	[Address(RVA = "0x882980", Offset = "0x881B80", VA = "0x180882980")]
	public bool TryLoadSubtitle()
	{
		return default(bool);
	}

	[Token(Token = "0x6004153")]
	[Address(RVA = "0x881310", Offset = "0x880510", VA = "0x180881310", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004154")]
	[Address(RVA = "0x881590", Offset = "0x880790", VA = "0x180881590", Slot = "16")]
	protected override void ProgressFinish()
	{
	}

	[Token(Token = "0x6004155")]
	[Address(RVA = "0x8811C0", Offset = "0x8803C0", VA = "0x1808811C0")]
	private void InitUI()
	{
	}

	[Token(Token = "0x6004156")]
	[Address(RVA = "0x881030", Offset = "0x880230", VA = "0x180881030", Slot = "24")]
	public void CollectLoadPath(List<(string path, Type type)> res)
	{
	}

	[Token(Token = "0x6004157")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "25")]
	public void CollectLoadMrk(List<int> res)
	{
	}

	[Token(Token = "0x6004158")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60", Slot = "23")]
	public bool IsFadeInTransitionCompleted()
	{
		return default(bool);
	}
}
