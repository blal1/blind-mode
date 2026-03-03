using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x20001F1")]
public class EventPlayableAsset : PlayableAsset
{
	[Serializable]
	[Token(Token = "0x20001F2")]
	public class EventInfo
	{
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x18")]
		public double time;

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public EventInfo()
		{
		}
	}

	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x18")]
	public string label;

	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x20")]
	public List<EventInfo> eventList;

	[Token(Token = "0x1700014E")]
	public override double duration
	{
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xC08510", Offset = "0xC07710", VA = "0x180C08510", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0xC08170", Offset = "0xC07370", VA = "0x180C08170", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0xC08490", Offset = "0xC07690", VA = "0x180C08490")]
	public EventPlayableAsset()
	{
	}
}
