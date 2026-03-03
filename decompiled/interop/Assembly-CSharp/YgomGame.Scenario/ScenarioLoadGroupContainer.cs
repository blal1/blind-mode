using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A69")]
public class ScenarioLoadGroupContainer : MonoBehaviour
{
	[Token(Token = "0x40091EA")]
	[FieldOffset(Offset = "0x20")]
	private List<ScenarioBehaviour> m_AllBehaviours;

	[Token(Token = "0x40091EB")]
	[FieldOffset(Offset = "0x28")]
	private int m_LoadingCount;

	[Token(Token = "0x40091EC")]
	[FieldOffset(Offset = "0x30")]
	private List<(string path, Type type)> m_LoadPaths;

	[Token(Token = "0x40091ED")]
	[FieldOffset(Offset = "0x38")]
	private List<int> m_LoadMrks;

	[Token(Token = "0x40091EE")]
	[FieldOffset(Offset = "0x40")]
	private List<string> m_SectionAssetPaths;

	[Token(Token = "0x40091EF")]
	[FieldOffset(Offset = "0x48")]
	private List<string> m_SectionLoadedAssetPaths;

	[Token(Token = "0x40091F0")]
	[FieldOffset(Offset = "0x50")]
	private List<string> m_SectionSoundLabels;

	[Token(Token = "0x40091F1")]
	[FieldOffset(Offset = "0x58")]
	private List<string> m_SectionLoadedSoundLabels;

	[Token(Token = "0x40091F2")]
	[FieldOffset(Offset = "0x60")]
	private ScenarioBehaviour_LoadGroup_Begin m_CurrentBeginBehaviour;

	[Token(Token = "0x40091F3")]
	[FieldOffset(Offset = "0x68")]
	private ScenarioBehaviour_LoadGroup_End m_CurrentEndBehaviour;

	[Token(Token = "0x600401C")]
	[Address(RVA = "0x884A00", Offset = "0x883C00", VA = "0x180884A00")]
	public static ScenarioLoadGroupContainer Create(GameObject owner, List<ScenarioBehaviour> allBehaviours)
	{
		return null;
	}

	[Token(Token = "0x600401D")]
	[Address(RVA = "0x884960", Offset = "0x883B60", VA = "0x180884960")]
	private void Clear()
	{
	}

	[Token(Token = "0x600401E")]
	[Address(RVA = "0x884820", Offset = "0x883A20", VA = "0x180884820")]
	public void AssignPreloadSectionContent(IScenarioPreloadBehaviour behaviour)
	{
	}

	[Token(Token = "0x600401F")]
	[Address(RVA = "0x8853B0", Offset = "0x8845B0", VA = "0x1808853B0")]
	public void SubmitPreloadSection()
	{
	}

	[Token(Token = "0x6004020")]
	[Address(RVA = "0x885B70", Offset = "0x884D70", VA = "0x180885B70")]
	public void UnloadPreloadSection()
	{
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0x884C00", Offset = "0x883E00", VA = "0x180884C00")]
	public bool LoadGroup(ScenarioBehaviour_LoadGroup_Begin beginBehaviour)
	{
		return default(bool);
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0x5EB0F0", Offset = "0x5EA2F0", VA = "0x1805EB0F0")]
	public bool IsLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6004023")]
	[Address(RVA = "0x885B30", Offset = "0x884D30", VA = "0x180885B30")]
	public bool UnloadGroup(ScenarioBehaviour_LoadGroup_End beginBehaviour)
	{
		return default(bool);
	}

	[Token(Token = "0x6004024")]
	[Address(RVA = "0x885940", Offset = "0x884B40", VA = "0x180885940")]
	public void UnloadAll()
	{
	}

	[Token(Token = "0x6004025")]
	[Address(RVA = "0x8853A0", Offset = "0x8845A0", VA = "0x1808853A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004026")]
	[Address(RVA = "0x8847C0", Offset = "0x8839C0", VA = "0x1808847C0")]
	private void AddLoadingCount()
	{
	}

	[Token(Token = "0x6004027")]
	[Address(RVA = "0x884BA0", Offset = "0x883DA0", VA = "0x180884BA0")]
	private void DecLoadingCount()
	{
	}

	[Token(Token = "0x6004028")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ScenarioLoadGroupContainer()
	{
	}
}
