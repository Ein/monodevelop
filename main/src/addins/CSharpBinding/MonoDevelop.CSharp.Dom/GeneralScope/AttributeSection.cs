// 
// AttributeSection.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
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

using System;
using System.Linq;
using MonoDevelop.Projects.Dom;
using System.Collections.Generic;

namespace MonoDevelop.CSharp.Dom
{
	public class AttributeSection : AbstractCSharpNode
	{
		const int TargetRole = 101;
		
		public override NodeType NodeType {
			get {
				return NodeType.Unknown;
			}
		}
		
		public AttributeTarget AttributeTarget {
			get;
			set;
		}

		public Identifier TargetIdentifier {
			get { return (Identifier)GetChildByRole (TargetRole); }
		}

		public IEnumerable<Attribute> Attributes {
			get { return base.GetChildrenByRole (Roles.Attribute).Cast<Attribute> (); }
		}

		public override S AcceptVisitor<T, S> (ICSharpDomVisitor<T, S> visitor, T data)
		{
			return visitor.VisitAttributeSection (this, data);
		}
	}
	
	public enum AttributeTarget {
		None,
		Assembly,
		Module,
		
		Type,
		Param,
		Field,
		Return,
		Method,
		Unknown
	}
}
