using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AA9")]
public class ScenarioBehaviour_PrefabCreate : ScenarioBehaviour, IScenarioLoadGroupHandleBehaviour
{
	[Token(Token = "0x400933F")]
	[FieldOffset(Offset = "0x50")]
	private bool m_CreateRequested;

	[Token(Token = "0x4009340")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_CreatedObj;

	[Token(Token = "0x6004177")]
	[Address(RVA = "0x87EED0", Offset = "0x87E0D0", VA = "0x18087EED0")]
	public ScenarioBehaviour_PrefabCreate(object commandData)
	{
	}

	[Token(Token = "0x6004178")]
	[Address(RVA = "0x898320", Offset = "0x897520", VA = "0x180898320", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004179")]
	[Address(RVA = "0x8981C0", Offset = "0x8973C0", VA = "0x1808981C0", Slot = "13")]
	protected override void ProgressAction()
	{
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0x898030", Offset = "0x897230", VA = "0x180898030", Slot = "23")]
	public void CollectLoadPath(List<(string path, Type type)> res)
	{
	}

	[Token(Token = "0x600417B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "24")]
	public void CollectLoadMrk(List<int> res)
	{
	}
}
