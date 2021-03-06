// NewOverrideCompletionData.cs
//
// Author:
//   Mike Krüger <mkrueger@novell.com>
//
// Copyright (c) 2008 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Linq;
using System.Text;
using MonoDevelop.Ide.CodeCompletion;
using MonoDevelop.Projects.Dom;
using MonoDevelop.Projects.Dom.Output;

using MonoDevelop.Ide.Gui;
using MonoDevelop.Ide.Gui.Content;
using MonoDevelop.Projects.Dom.Parser;
using System.Collections.Generic;
using MonoDevelop.CSharp.Dom;
using MonoDevelop.Projects.CodeGeneration;
using Mono.TextEditor;
using MonoDevelop.CSharp.Refactoring;

namespace MonoDevelop.CSharp.Completion
{
	public class NewOverrideCompletionData : CompletionData
	{
		TextEditorData editor;
		IMember member;
		static Ambience ambience = new CSharpAmbience ();
		int    declarationBegin;
		IType  type;
		
		public bool GenerateBody { get; set; }
		
		public NewOverrideCompletionData (ProjectDom dom, TextEditorData editor, int declarationBegin, IType type, IMember member) : base (null)
		{
			this.editor = editor;
			this.type   = type;
			this.member = member;
			
			this.declarationBegin = declarationBegin;
			this.GenerateBody = true;
			this.Icon = member.StockIcon;
			this.DisplayText = ambience.GetString (member, OutputFlags.IncludeParameters | OutputFlags.IncludeGenerics | OutputFlags.HideExtensionsParameter);
			this.CompletionText = member.Name;
		}
		
		public override void InsertCompletionText (CompletionListWindow window)
		{
			CodeGenerator generator = CodeGenerator.CreateGenerator (editor.Document.MimeType, editor.Options.TabsToSpaces, editor.Options.TabSize, editor.EolMarker);
			var result = generator.CreateMemberImplementation (type, member, false);
			string sb = result.Code.TrimStart ();
			int trimStart = result.Code.Length - sb.Length;
			sb = sb.TrimEnd ();
			
			var lastRegion = result.BodyRegions.LastOrDefault ();
			var region = lastRegion == null? null
				: new CodeGeneratorBodyRegion (lastRegion.StartOffset - trimStart, lastRegion.EndOffset - trimStart);
			
			int targetCaretPosition;
			int selectionEndPosition = -1;
			if (region != null && region.IsValid) {
				targetCaretPosition = declarationBegin + region.StartOffset;
				if (region.Length > 0) {
					if (GenerateBody) {
						selectionEndPosition = declarationBegin + region.EndOffset;
					} else {
						//FIXME: if there are multiple regions, remove all of them
						sb = sb.Substring (0, region.StartOffset) + sb.Substring (region.EndOffset); 
					}
				}
			} else {
				targetCaretPosition = declarationBegin + sb.Length;
			}
			
			editor.Replace (declarationBegin, editor.Caret.Offset - declarationBegin, sb);
			if (selectionEndPosition > 0) {
				editor.Caret.Offset = selectionEndPosition;
				editor.SetSelection (targetCaretPosition, selectionEndPosition);
			} else {
				editor.Caret.Offset = targetCaretPosition;
			}
		}
	}
}
