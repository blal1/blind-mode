using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A94")]
[CreateAssetMenu(menuName = "Scriptable Object/シナリオ登場カードデータ生成")]
public class ScenarioCardsAsset : ScriptableObject
{
	[Token(Token = "0x40092DD")]
	private const string k_PathFormat = "Scenarios/Gates/ScenarioCards/{0}";

	[Token(Token = "0x40092DE")]
	[FieldOffset(Offset = "0x18")]
	public List<int> mrks;

	[Token(Token = "0x600410F")]
	[Address(RVA = "0x8843A0", Offset = "0x8835A0", VA = "0x1808843A0")]
	public static void LoadAsync(string scenarioName, Action<ScenarioCardsAsset> onFinished)
	{
	}

	[Token(Token = "0x6004110")]
	[Address(RVA = "0x8844B0", Offset = "0x8836B0", VA = "0x1808844B0")]
	public ScenarioCardsAsset()
	{
	}
}
