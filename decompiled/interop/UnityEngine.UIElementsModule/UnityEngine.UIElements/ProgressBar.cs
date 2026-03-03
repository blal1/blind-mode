using System;
using Il2CppDummyDll;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x200012C")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class ProgressBar : AbstractProgressBar
{
	[Token(Token = "0x200012D")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<ProgressBar, UxmlTraits>
	{
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x2AEF730", Offset = "0x2AEE930", VA = "0x182AEF730")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0x2ADCEF0", Offset = "0x2ADC0F0", VA = "0x182ADCEF0")]
	public ProgressBar()
	{
	}
}
