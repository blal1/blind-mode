using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A73")]
public class SelectingCursorManager : MonoBehaviour
{
	[Token(Token = "0x400F3A0")]
	[FieldOffset(Offset = "0x20")]
	private RunEffectWorker worker;

	[Token(Token = "0x400F3A1")]
	[FieldOffset(Offset = "0x28")]
	private GameObject effArrow;

	[Token(Token = "0x400F3A2")]
	[FieldOffset(Offset = "0x30")]
	private SimpleEffect effCard;

	[Token(Token = "0x400F3A3")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 curPos;

	[Token(Token = "0x400F3A4")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion curRot;

	[Token(Token = "0x400F3A5")]
	[FieldOffset(Offset = "0x58")]
	private SimpleEffect highlightEff;

	[Token(Token = "0x400F3A6")]
	[FieldOffset(Offset = "0x60")]
	private int currentCursorPlayer;

	[Token(Token = "0x400F3A7")]
	[FieldOffset(Offset = "0x64")]
	private int currentCursorPosition;

	[Token(Token = "0x400F3A8")]
	[FieldOffset(Offset = "0x68")]
	private int currentCursorViewIndex;

	[Token(Token = "0x400F3A9")]
	[FieldOffset(Offset = "0x70")]
	private List<GameObject> cursorEffect;

	[Token(Token = "0x400F3AA")]
	[FieldOffset(Offset = "0x78")]
	private int cursorEffectPlayer;

	[Token(Token = "0x400F3AB")]
	[FieldOffset(Offset = "0x7C")]
	private int cursorEffectPosition;

	[Token(Token = "0x400F3AC")]
	[FieldOffset(Offset = "0x80")]
	private int cursorEffectViewIndex;

	[Token(Token = "0x400F3AD")]
	[FieldOffset(Offset = "0x84")]
	private bool cursorEffectPhaseButton;

	[Token(Token = "0x400F3AE")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<string, Queue<GameObject>> cursorEffectPool;

	[Token(Token = "0x400F3AF")]
	[FieldOffset(Offset = "0x90")]
	private Transform poolParent;

	[Token(Token = "0x400F3B0")]
	private const string prefabPathBase = "Duel/Models/FieldPadCursor/FieldPadCursor";

	[Token(Token = "0x400F3B1")]
	private const string prefabPathArrow = "Prefabs/Duel/SelectingArrow";

	[Token(Token = "0x400F3B2")]
	private const string prefabPathCursorExclude = "Duel/Models/FieldPadCursor/FieldPadCursorExclude";

	[Token(Token = "0x400F3B3")]
	private const string prefabPathCursorField = "Duel/Models/FieldPadCursor/FieldPadCursorField";

	[Token(Token = "0x400F3B4")]
	private const string prefabPathCursorGrave = "Duel/Models/FieldPadCursor/FieldPadCursorGrave";

	[Token(Token = "0x400F3B5")]
	private const string prefabPathCursorMagic = "Duel/Models/FieldPadCursor/FieldPadCursorMagic";

	[Token(Token = "0x400F3B6")]
	private const string prefabPathCursorMonster = "Duel/Models/FieldPadCursor/FieldPadCursorMonster";

	[Token(Token = "0x400F3B7")]
	private const string prefabPathCursorPhase = "Duel/Models/FieldPadCursor/FieldPadCursorPhase";

	[Token(Token = "0x400F3B8")]
	private const string prefabPathCursorCard = "Duel/Models/FieldPadCursor/FieldPadCursorCard";

	[Token(Token = "0x400F3B9")]
	[FieldOffset(Offset = "0x98")]
	private GameObject prefabArrow;

	[Token(Token = "0x400F3BA")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject prefabCursorExclude;

	[Token(Token = "0x400F3BB")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject prefabCursorField;

	[Token(Token = "0x400F3BC")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject prefabCursorGrave;

	[Token(Token = "0x400F3BD")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject prefabCursorMagic;

	[Token(Token = "0x400F3BE")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject prefabCursorMonster;

	[Token(Token = "0x400F3BF")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject prefabCursorPhase;

	[Token(Token = "0x400F3C0")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject prefabCursorCard;

	[Token(Token = "0x400F3C1")]
	[FieldOffset(Offset = "0xD8")]
	private int setPlayer;

	[Token(Token = "0x400F3C2")]
	[FieldOffset(Offset = "0xDC")]
	private int setPosition;

	[Token(Token = "0x400F3C3")]
	[FieldOffset(Offset = "0xE0")]
	private int setViewIndex;

	[Token(Token = "0x17001A7D")]
	public bool isReady
	{
		[Token(Token = "0x600ABB8")]
		[Address(RVA = "0x4303D0", Offset = "0x42F5D0", VA = "0x1804303D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600ABB9")]
	[Address(RVA = "0x42E0B0", Offset = "0x42D2B0", VA = "0x18042E0B0")]
	public static SelectingCursorManager Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x600ABBA")]
	[Address(RVA = "0x42E7E0", Offset = "0x42D9E0", VA = "0x18042E7E0")]
	private void LoadCursorPrefab()
	{
	}

	[Token(Token = "0x600ABBB")]
	[Address(RVA = "0x42E710", Offset = "0x42D910", VA = "0x18042E710")]
	private void LoadAsset(string path, Action<GameObject> loadedCallback)
	{
	}

	[Token(Token = "0x600ABBC")]
	[Address(RVA = "0x42FBB0", Offset = "0x42EDB0", VA = "0x18042FBB0")]
	public void StartDisp(int team, int position, int index)
	{
	}

	[Token(Token = "0x600ABBD")]
	[Address(RVA = "0x42F730", Offset = "0x42E930", VA = "0x18042F730")]
	private void StartDispImpl(Vector3 pos, Quaternion rot, bool isForce)
	{
	}

	[Token(Token = "0x600ABBE")]
	[Address(RVA = "0x42E1C0", Offset = "0x42D3C0", VA = "0x18042E1C0")]
	public void EndDisp()
	{
	}

	[Token(Token = "0x600ABBF")]
	[Address(RVA = "0x42EAA0", Offset = "0x42DCA0", VA = "0x18042EAA0")]
	public void RefreshDisp()
	{
	}

	[Token(Token = "0x600ABC0")]
	[Address(RVA = "0x42FEE0", Offset = "0x42F0E0", VA = "0x18042FEE0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600ABC1")]
	[Address(RVA = "0x42EEB0", Offset = "0x42E0B0", VA = "0x18042EEB0")]
	public void SetFocusHighlight(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600ABC2")]
	[Address(RVA = "0x42F130", Offset = "0x42E330", VA = "0x18042F130")]
	private void ShowHighlightEffect(int team, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600ABC3")]
	[Address(RVA = "0x42EFC0", Offset = "0x42E1C0", VA = "0x18042EFC0")]
	private void ShowHighlightEffect(Vector3 pos, Quaternion rot, DuelEffectPool.Type effectType)
	{
	}

	[Token(Token = "0x600ABC4")]
	[Address(RVA = "0x42E360", Offset = "0x42D560", VA = "0x18042E360")]
	public void HideHighlightEffect()
	{
	}

	[Token(Token = "0x600ABC5")]
	[Address(RVA = "0x42EC90", Offset = "0x42DE90", VA = "0x18042EC90")]
	public void SelectCurrentTarget()
	{
	}

	[Token(Token = "0x600ABC6")]
	[Address(RVA = "0x42ECC0", Offset = "0x42DEC0", VA = "0x18042ECC0")]
	public bool Select(int player, int position, int viewIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600ABC7")]
	[Address(RVA = "0x42F620", Offset = "0x42E820", VA = "0x18042F620")]
	public void ShowPositionPadCursor(int player, int position, int viewIndex)
	{
	}

	[Token(Token = "0x600ABC8")]
	[Address(RVA = "0x42F4B0", Offset = "0x42E6B0", VA = "0x18042F4B0")]
	public void ShowPhasePadCursor()
	{
	}

	[Token(Token = "0x600ABC9")]
	[Address(RVA = "0x42F3A0", Offset = "0x42E5A0", VA = "0x18042F3A0")]
	private void ShowPadCursor(GameObject cursorObject)
	{
	}

	[Token(Token = "0x600ABCA")]
	[Address(RVA = "0x42E000", Offset = "0x42D200", VA = "0x18042E000")]
	private GameObject CreatePositionPadCursor(int position, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600ABCB")]
	[Address(RVA = "0x42DEC0", Offset = "0x42D0C0", VA = "0x18042DEC0")]
	private GameObject CreatePhasePadCursor()
	{
		return null;
	}

	[Token(Token = "0x600ABCC")]
	[Address(RVA = "0x42DC90", Offset = "0x42CE90", VA = "0x18042DC90")]
	private GameObject CreatePadCursor(GameObject prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600ABCD")]
	[Address(RVA = "0x42E290", Offset = "0x42D490", VA = "0x18042E290")]
	private GameObject GetPadCursorPrefab(int position)
	{
		return null;
	}

	[Token(Token = "0x600ABCE")]
	[Address(RVA = "0x42E3F0", Offset = "0x42D5F0", VA = "0x18042E3F0")]
	public void HidePadCursor(bool resetInfo = true)
	{
	}

	[Token(Token = "0x600ABCF")]
	[Address(RVA = "0x42EB60", Offset = "0x42DD60", VA = "0x18042EB60")]
	public void ReshowPadCursor()
	{
	}

	[Token(Token = "0x600ABD0")]
	[Address(RVA = "0x42FFF0", Offset = "0x42F1F0", VA = "0x18042FFF0")]
	public void UpdatePadCursor()
	{
	}

	[Token(Token = "0x600ABD1")]
	[Address(RVA = "0x4302E0", Offset = "0x42F4E0", VA = "0x1804302E0")]
	public SelectingCursorManager()
	{
	}
}
