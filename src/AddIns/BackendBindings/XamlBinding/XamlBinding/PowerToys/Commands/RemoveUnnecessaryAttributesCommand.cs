// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Siegfried Pammer" email="sie_pam@gmx.at"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Windows.Forms;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop;

namespace ICSharpCode.XamlBinding.PowerToys.Commands
{
	/// <summary>
	/// Description of RemoveUnneccessaryAttributesCommand
	/// </summary>
	public class RemoveUnnecessaryAttributesCommand : RemoveMarginCommand
	{
		protected override bool Refactor(ICSharpCode.SharpDevelop.Editor.ITextEditor editor, System.Xml.Linq.XDocument document)
		{
			RemoveRecursive(document.Root, "Margin");
			RemoveRecursive(document.Root, "MinWidth");
			RemoveRecursive(document.Root, "MinHeight");			
			return true;
		}
	}
}
