using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Pool;

namespace Unity.Properties;

[Token(Token = "0x2000004")]
public static class PropertyContainer
{
	[Token(Token = "0x2000005")]
	private class GetPropertyVisitor : PathVisitor
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ObjectPool<GetPropertyVisitor> Pool;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IProperty Property;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x28D8A40", Offset = "0x28D7C40", VA = "0x1828D8A40", Slot = "6")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600000A")]
		protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public GetPropertyVisitor()
		{
		}
	}

	[Token(Token = "0x2000007")]
	private class GetValueVisitor<TSrcValue> : PathVisitor
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ObjectPool<GetValueVisitor<TSrcValue>> Pool;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TSrcValue Value;

		[Token(Token = "0x6000011")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000012")]
		protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
		}

		[Token(Token = "0x6000013")]
		public GetValueVisitor()
		{
		}
	}

	[Token(Token = "0x6000002")]
	public static void Accept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, [Optional] VisitParameters parameters)
	{
	}

	[Token(Token = "0x6000003")]
	public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, [Optional] VisitParameters parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, out VisitReturnCode returnCode, [Optional] VisitParameters parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	public static bool TryGetProperty<TContainer>(ref TContainer container, in PropertyPath path, out IProperty property)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	public static bool TryGetProperty<TContainer>(ref TContainer container, in PropertyPath path, out IProperty property, out VisitReturnCode returnCode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	public static bool TryGetValue<TContainer, TValue>(ref TContainer container, string name, out TValue value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	public static bool TryGetValue<TContainer, TValue>(ref TContainer container, in PropertyPath path, out TValue value, out VisitReturnCode returnCode)
	{
		return default(bool);
	}
}
