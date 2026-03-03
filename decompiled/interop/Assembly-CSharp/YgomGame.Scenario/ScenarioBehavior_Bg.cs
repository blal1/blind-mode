using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A96")]
public class ScenarioBehavior_Bg : ScenarioBehaviour, IScenarioFadeInTransitionBehaviour, IScenarioLoadGroupHandleBehaviour, IScenarioPreloadSectionBehaviour, IScenarioPreloadAssetBehaviour, IScenarioPreloadBehaviour
{
	[Token(Token = "0x40092E0")]
	[FieldOffset(Offset = "0x50")]
	private readonly float k_SrcFadeAlpha;

	[Token(Token = "0x40092E1")]
	[FieldOffset(Offset = "0x54")]
	private readonly float k_DstFadeAlpha;

	[Token(Token = "0x40092E2")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsLoaded;

	[Token(Token = "0x40092E3")]
	[FieldOffset(Offset = "0x5C")]
	private float m_TotalFadeSec;

	[Token(Token = "0x40092E4")]
	[FieldOffset(Offset = "0x60")]
	private float m_FadeSec;

	[Token(Token = "0x40092E5")]
	[FieldOffset(Offset = "0x68")]
	private object m_RenderTarget;

	[Token(Token = "0x40092E6")]
	[FieldOffset(Offset = "0x70")]
	private object m_SubRenderTarget;

	[Token(Token = "0x6004113")]
	[Address(RVA = "0x87ED70", Offset = "0x87DF70", VA = "0x18087ED70")]
	public ScenarioBehavior_Bg(object commandData)
	{
	}

	[Token(Token = "0x6004114")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60", Slot = "23")]
	public bool IsFadeInTransitionCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6004115")]
	[Address(RVA = "0x87E900", Offset = "0x87DB00", VA = "0x18087E900", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004116")]
	[Address(RVA = "0x87E6D0", Offset = "0x87D8D0", VA = "0x18087E6D0", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x6004117")]
	[Address(RVA = "0x87E580", Offset = "0x87D780", VA = "0x18087E580", Slot = "24")]
	public void CollectLoadPath(List<(string path, Type type)> res)
	{
	}

	[Token(Token = "0x6004118")]
	[Address(RVA = "0x87E480", Offset = "0x87D680", VA = "0x18087E480", Slot = "26")]
	public void AssignPreloadAssetPath(List<string> assetPaths)
	{
	}

	[Token(Token = "0x6004119")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "25")]
	public void CollectLoadMrk(List<int> res)
	{
	}
}
