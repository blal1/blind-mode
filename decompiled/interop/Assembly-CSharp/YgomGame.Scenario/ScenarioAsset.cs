using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A93")]
[CreateAssetMenu(menuName = "Scriptable Object/シナリオ編集データ生成")]
public class ScenarioAsset : ScriptableObject, ISerializationCallbackReceiver
{
	[Token(Token = "0x40092DB")]
	[FieldOffset(Offset = "0x18")]
	private List<object> m_CommandList;

	[Token(Token = "0x40092DC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string[] m_CommandJsons;

	[Token(Token = "0x170008AA")]
	public List<object> commandList
	{
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004100")]
	[Address(RVA = "0x87CC40", Offset = "0x87BE40", VA = "0x18087CC40", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6004101")]
	[Address(RVA = "0x87CAE0", Offset = "0x87BCE0", VA = "0x18087CAE0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6004102")]
	[Address(RVA = "0x87C440", Offset = "0x87B640", VA = "0x18087C440")]
	public static object CreateCommand()
	{
		return null;
	}

	[Token(Token = "0x6004103")]
	[Address(RVA = "0x87C9C0", Offset = "0x87BBC0", VA = "0x18087C9C0")]
	public static string GetCommandKey(object commandData)
	{
		return null;
	}

	[Token(Token = "0x6004104")]
	[Address(RVA = "0x87D1F0", Offset = "0x87C3F0", VA = "0x18087D1F0")]
	public static void SetCommandKey(object commandData, string key)
	{
	}

	[Token(Token = "0x6004105")]
	[Address(RVA = "0x87C880", Offset = "0x87BA80", VA = "0x18087C880")]
	public static ScenarioDef.BehaviourAsyncMode GetAsyncMode(object commandData)
	{
		return default(ScenarioDef.BehaviourAsyncMode);
	}

	[Token(Token = "0x6004106")]
	[Address(RVA = "0x87D070", Offset = "0x87C270", VA = "0x18087D070")]
	public static void SetAsyncMode(object commandData, ScenarioDef.BehaviourAsyncMode value)
	{
	}

	[Token(Token = "0x6004107")]
	[Address(RVA = "0x87C6A0", Offset = "0x87B8A0", VA = "0x18087C6A0")]
	public static Dictionary<string, object> GetArgs(object commandData)
	{
		return null;
	}

	[Token(Token = "0x6004108")]
	[Address(RVA = "0x87C930", Offset = "0x87BB30", VA = "0x18087C930")]
	public string GetCommandKeyByIdx(int index)
	{
		return null;
	}

	[Token(Token = "0x6004109")]
	[Address(RVA = "0x87D130", Offset = "0x87C330", VA = "0x18087D130")]
	public void SetCommandKeyByIdx(int index, string commandKey)
	{
	}

	[Token(Token = "0x600410A")]
	[Address(RVA = "0x87CA30", Offset = "0x87BC30", VA = "0x18087CA30")]
	public bool IsSupportedAsyncEditByIdx(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600410B")]
	[Address(RVA = "0x87C780", Offset = "0x87B980", VA = "0x18087C780")]
	public ScenarioDef.BehaviourAsyncMode GetAsyncModeByIdx(int index)
	{
		return default(ScenarioDef.BehaviourAsyncMode);
	}

	[Token(Token = "0x600410C")]
	[Address(RVA = "0x87CF70", Offset = "0x87C170", VA = "0x18087CF70")]
	public void SetAsyncModeByIdx(int index, ScenarioDef.BehaviourAsyncMode value)
	{
	}

	[Token(Token = "0x600410D")]
	[Address(RVA = "0x87C580", Offset = "0x87B780", VA = "0x18087C580")]
	public Dictionary<string, object> GetArgsByIdx(int index)
	{
		return null;
	}

	[Token(Token = "0x600410E")]
	[Address(RVA = "0x87D260", Offset = "0x87C460", VA = "0x18087D260")]
	public ScenarioAsset()
	{
	}
}
